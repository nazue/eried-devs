using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using System.Threading;
using TemperatureLogger.Properties;

namespace TemperatureLogger
{
    public partial class FormMain : Form
    {
        PointPairList temperatureData = new PointPairList();
        string lastPortUsed = "", AppTitle, AppTitleDisconnected;
        bool lastAppStatus = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            GraphInitialization();

            AppTitle = Properties.Resources.AppTitleConnected;
            AppTitleDisconnected = Properties.Resources.AppTitleDisconnected;

            UpdateSerialPorts();
            UpdateApplicationStatus();

            LoadApplicationSettings();

            if(Settings.Default.configAutoConnect)
                OpenPort();
        }

        private void LoadApplicationSettings()
        {
            smoothGraphToolStripMenuItem.Checked = Settings.Default.configSmoothGraph;
            startupAutoConnectToolStripMenuItem.Checked = Settings.Default.configAutoConnect;
        }

        private void GraphInitialization()
        {
            zedGraphControlTemperature.GraphPane.Title.IsVisible = false;
            zedGraphControlTemperature.GraphPane.XAxis.Type = AxisType.Date;

            zedGraphControlTemperature.GraphPane.XAxis.Title.Text = Properties.Resources.GraphLabelDatetime;
            zedGraphControlTemperature.GraphPane.YAxis.Title.Text = Properties.Resources.GraphLabelCelsius;
            zedGraphControlTemperature.GraphPane.YAxis.Title.IsOmitMag = true;

            zedGraphControlTemperature.GraphPane.YAxis.Scale.BaseTic = 24;
            zedGraphControlTemperature.GraphPane.XAxis.Scale.BaseTic = GetActualTimeInDouble();
            zedGraphControlTemperature.GraphPane.XAxis.Scale.Format = Properties.Resources.GraphScaleFormat;

            zedGraphControlTemperature.GraphPane.CurveList.Clear();
            LineItem c = zedGraphControlTemperature.GraphPane.AddCurve(Properties.Resources.GraphLabelTemperature,
                  temperatureData, Color.Red, SymbolType.Circle);

            zedGraphControlTemperature.AxisChange();
            c.Line.SmoothTension = 0.6F;
            c.Line.Width = 3;
            c.Line.IsSmooth = smoothGraphToolStripMenuItem.Checked;

            zedGraphControlTemperature.Refresh();
        }


        delegate void SetTextCallback(string text);

        private void ProcessReceivedData(string text)
        {
            if (this.zedGraphControlTemperature.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ProcessReceivedData);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                temperatureData.Add(GetActualTimeInDouble(), ConvertToCelsius(Convert.ToDouble(text.Split(':')[1])));
                zedGraphControlTemperature.AxisChange();
                zedGraphControlTemperature.PerformAutoScale();
                zedGraphControlTemperature.Refresh();
            }
        }

        private double GetActualTimeInDouble()
        {
            return ((TimeSpan)DateTime.Now.Subtract(new DateTime(1900,1,1))).TotalDays;
        }

        private double ConvertToCelsius(double p)
        {
            return p;
        }


        private void serialPortArduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int bytesToRead = serialPortArduino.BytesToRead;

            if (bytesToRead >= 13)
            {
                char[] z = new char[13];
                serialPortArduino.Read(z, 0, 13);

                string n = new string(z);
                ProcessReceivedData(n);
            }
        }



        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateApplicationSettings();
            Settings.Default.Save();
            ClosePort();
        }

        private void UpdateApplicationSettings()
        {
            Settings.Default.configSmoothGraph = smoothGraphToolStripMenuItem.Checked;
            Settings.Default.configAutoConnect = startupAutoConnectToolStripMenuItem.Checked;
        }

        private void ClosePort()
        {
            try
            {
                serialPortArduino.Close();
                SetApplicationStatus(false);
            }
            catch { }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPort();
        }

        private void OpenPort()
        {
            try
            {
                serialPortArduino.PortName = (string)toolStripComboBoxPort.SelectedItem;
                serialPortArduino.Open();
                lastPortUsed = serialPortArduino.PortName;
                SetApplicationStatus(true);
            }
            catch { }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClosePort();
        }

        private void updatePortListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSerialPorts();
        }

        private void UpdateSerialPorts()
        {
            toolStripComboBoxPort.Items.Clear();

            foreach(String d in SerialPort.GetPortNames())
                if(!d.EndsWith("c"))
                    toolStripComboBoxPort.Items.Add(d);

            toolStripComboBoxPort.SelectedIndex =toolStripComboBoxPort.Items.Count-1;
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateSerialPorts();
        }

        private void conectarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenPort();
        }

        private void desconectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClosePort();
        }

        private void UpdateApplicationStatus()
        {
            SetApplicationStatus(lastAppStatus);
        }

        private void SetApplicationStatus(bool b)
        {
            this.Text = String.Format((!b ? AppTitleDisconnected : AppTitle),lastPortUsed);
            connectToolStripMenuItem.Enabled = !b;
            disconnectToolStripMenuItem1.Enabled = b;
            toolStripComboBoxPort.Enabled = !b;
            updatePortsToolStripMenuItem.Enabled = !b;

            // Recordar el último estado de la aplicación
            lastAppStatus = b;
        }

        private void uptadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void CheckStatus()
        {
            SetApplicationStatus(serialPortArduino.IsOpen);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.AppAboutText, Resources.AppAboutTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void smoothGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphInitialization();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.Filter = Resources.AppExportFilter;
            saveFileDialogExport.Title = Resources.AppExportTitle;

            try
            {
                if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
                {
                    List<String> output = new List<string>();
                    if (saveFileDialogExport.FilterIndex == 1)
                        output.Add(Resources.AppExportColumnsHeader);

                    foreach (PointPair p in temperatureData)
                        output.Add(String.Format(Resources.AppExportColumnsFormat, p.X, p.Y));

                    System.IO.File.WriteAllLines(saveFileDialogExport.FileName, output.ToArray());

                }
            }
            catch 
            {
                MessageBox.Show(Resources.AppExportErrorText, Resources.AppExportErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}