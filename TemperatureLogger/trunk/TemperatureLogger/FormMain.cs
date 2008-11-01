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

namespace TemperatureLogger
{
    public partial class FormMain : Form
    {
        PointPairList temperatureData = new PointPairList();
        string lastPortUsed = "", AppTitle, AppTitleDisconnected;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            zedGraphControlTemperature.GraphPane.Title.IsVisible = false;
            zedGraphControlTemperature.GraphPane.XAxis.Type = AxisType.Date;

            zedGraphControlTemperature.GraphPane.XAxis.Title.Text = Properties.Resources.GraphLabelDatetime;
            zedGraphControlTemperature.GraphPane.YAxis.Title.Text = Properties.Resources.GraphLabelCelsius;
            zedGraphControlTemperature.GraphPane.YAxis.Title.IsOmitMag = true;

            zedGraphControlTemperature.GraphPane.YAxis.Scale.BaseTic = 24;
            //this.zedGraphControlTemperature.PointValueEvent += new ZedGraphControl.PointValueHandler(YScaleFormatEvent);
            //zedGraphControlTemperature.GraphPane.YAxis.ScaleTitleEvent += new Axis.ScaleFormatHandler(YScaleFormatEvent);
            zedGraphControlTemperature.GraphPane.XAxis.Scale.BaseTic = GetActualTimeInDouble();
            zedGraphControlTemperature.GraphPane.XAxis.Scale.Format = "G";

            LineItem c = zedGraphControlTemperature.GraphPane.AddCurve(Properties.Resources.GraphLabelTemperature,
                  temperatureData, Color.Red, SymbolType.Circle);

            c.Line.IsSmooth = true;
            c.Line.SmoothTension = 0.6F;
            c.Line.Width = 3;

            zedGraphControlTemperature.AxisChange();

            AppTitle = Properties.Resources.AppTitleConnected;
            AppTitleDisconnected = Properties.Resources.AppTitleDisconnected;

            UpdateSerialPorts();
            OpenPort();
        }


        delegate void SetTextCallback(string text);
        /*
        public string YScaleFormatEvent(ZedGraphControl c, GraphPane pane, CurveItem v, int index)
        {
            return v.Points[index] ZedGraph.; // /*(v. / 100).ToString("f2") + " " + Properties.Resources.GraphLabelTemperature
        }*/

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
            ClosePort();
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

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPort();
        }

        private void OpenPort()
        {
            try
            {
                serialPortArduino.PortName = (string)toolStripComboBox1.SelectedItem;
                serialPortArduino.Open();
                lastPortUsed = serialPortArduino.PortName;
                SetApplicationStatus(true);
            }
            catch { }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClosePort();
        }

        private void actualizarPuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSerialPorts();
        }

        private void UpdateSerialPorts()
        {
            toolStripComboBox1.Items.Clear();

            foreach(String d in SerialPort.GetPortNames())
                if(!d.EndsWith("c"))
                    toolStripComboBox1.Items.Add(d);

            toolStripComboBox1.SelectedIndex =toolStripComboBox1.Items.Count-1;
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

        private void SetApplicationStatus(bool b)
        {
            this.Text = String.Format((!b ? AppTitleDisconnected : AppTitle),lastPortUsed);
            conectarToolStripMenuItem.Enabled = !b;
            desconectarToolStripMenuItem1.Enabled = b;
            toolStripComboBox1.Enabled = !b;
            actualizarToolStripMenuItem1.Enabled = !b;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void CheckStatus()
        {
            SetApplicationStatus(serialPortArduino.IsOpen);
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Erwin Ried\nVersión 1.0\n\nEsta aplicación utiliza ZedGraph Class Library\nhttp://zedgraph.sourceforge.net", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}