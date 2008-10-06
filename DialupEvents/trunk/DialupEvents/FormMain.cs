using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DialupEvents.Properties;
using System.Collections;
using System.IO;

namespace DialupEvents
{
    public partial class FormMain : Form
    {
        private ArrayList currentEvents;
        private DateTime callStart;
        private int totalSeconds;

        public FormMain()
        {
            InitializeComponent();
        }

        private void guiMode(bool a)
        {
            if (a)
            {
                // Actualizar lista
                this.listDialupEvents.Items.Clear();
                foreach (ListViewItem e in currentEvents)
                {
                    this.listDialupEvents.Items.Add(e);
                }

                this.UseWaitCursor = false;
            }
            else
            {
                this.UseWaitCursor = true;
            }
            
            listDialupEvents.Enabled = a;
            buttonCalculateCost.Enabled = a;
            buttonUpdate.Enabled = a;
            buttonExport.Enabled = a;
            dateTimePickerEnd.Enabled = a;
            dateTimePickerIni.Enabled = a;
        }

        private void updateEventList()
        {
            guiMode(false);

            currentEvents.Clear();
            totalSeconds = 0;

            EventLog[] eventLogs = EventLog.GetEventLogs();
            foreach (EventLog eventCollection in eventLogs)
            {
                if (eventCollection.Log.CompareTo("System") == 0)
                {

                    foreach (EventLogEntry eventLogEntry in eventCollection.Entries)
                    {
                        if (eventLogEntry.Source == "RemoteAccess")
                        {
                            // Añadirlo a la lista
                            ListViewItem status = new ListViewItem();

                            DateTime eTime = new DateTime();
                            eTime = eventLogEntry.TimeGenerated;

                            if (eTime.Ticks > dateTimePickerEnd.Value.AddDays(1).Ticks)
                            {
                                break;
                            }
                            else
                            {
                                if (eTime.Ticks > dateTimePickerIni.Value.Ticks)
                                {
                                    status.SubItems.Add(eTime.ToShortDateString());
                                    status.SubItems.Add(eTime.ToLongTimeString());


                                    switch (eventLogEntry.InstanceId)
                                    {
                                        case 20158:
                                            status.ImageIndex = 1;
                                            status.Text = String.Format(Resources.ResourceManager.GetString("DialupStart_msg"), eventLogEntry.ReplacementStrings[1]);
                                            callStart = eTime;
                                            break;
                                        case 20159:
                                            status.ImageIndex = 2;
                                            status.Text = Resources.ResourceManager.GetString("DialupEnd_msg");

                                            TimeSpan callTotal = new TimeSpan(Math.Max(eTime.Ticks - callStart.Ticks, 0));
                                            totalSeconds += (int)callTotal.TotalSeconds;
                                            status.SubItems.Add(String.Format("{0:00}:{1:00}:{2:00}",callTotal.Hours,callTotal.Minutes,callTotal.Seconds));
                                            break;
                                        default:
                                            break;
                                    }
                                    currentEvents.Add(status);
                                }
                            }
                        }
                    }

                    break;
                }

            }
            guiMode(true);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Configuración de la ventana
            this.Top = Settings.Default.windowTop;
            this.Left = Settings.Default.windowLeft;
            this.Width = Settings.Default.windowWidth;
            this.Height = Settings.Default.windowHeight;
            this.WindowState = Settings.Default.windowState;

            // Inicio de la aplicación
            currentEvents = new ArrayList();
            DateTime now = DateTime.Now;
            DateTime end = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            dateTimePickerEnd.Value = end;
            dateTimePickerIni.Value = dateTimePickerEnd.Value.AddMonths(-1);
            updateEventList();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateEventList();
        }

        private void calcularCostoDeConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCostDialog();
        }

        private void showCostDialog()
        {
            Form costo = new FormCost(totalSeconds, Properties.Settings.Default.defaultCost);
            costo.ShowDialog();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerIni.MaxDate = dateTimePickerEnd.Value;
            updateEventList();
        }

        private void dateTimePickerIni_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerIni.Value;
            updateEventList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            updateEventList();
        }

        private void buttonCalculateCost_Click(object sender, EventArgs e)
        {
            showCostDialog();
        }

        private void saveWindowPositionSize()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    Settings.Default.windowTop = this.Top;
                    Settings.Default.windowLeft = this.Left;
                    Settings.Default.windowWidth = this.Width;
                    Settings.Default.windowHeight = this.Height;
                    Settings.Default.windowState = this.WindowState;
                    break;
                case FormWindowState.Maximized:
                    Settings.Default.windowState = this.WindowState;
                    break;
            }

            Settings.Default.Save();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveWindowPositionSize();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            saveWindowPositionSize();
        }

        private void exportEvents(ArrayList _thisCurrentEvents)
        {
            saveLogFileDialog.FileName = Resources.LogFile_filename + "_" + 
                dateTimePickerIni.Value.ToShortDateString() + "_" +
                dateTimePickerEnd.Value.ToShortDateString() + ".txt";

            if (saveLogFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter logFile = File.CreateText(saveLogFileDialog.FileName);
                logFile.WriteLine("{0}\t{1}\t{2}\t{3}", Resources.LogFile_header.Split(';'));
               
                String lastItem;

                foreach (ListViewItem z in _thisCurrentEvents)
                {
                    if (z.SubItems.Count == 4)
                    {
                        lastItem = z.SubItems[3].Text;
                    }
                    else
                    {
                        lastItem = "";
                    }

                    logFile.WriteLine("{0}\t{1}\t{2}\t{3}", 
                        z.SubItems[0].Text, 
                        z.SubItems[1].Text, 
                        z.SubItems[2].Text,
                        lastItem);
                }

                logFile.Close();
            }
        }

        private void exportAllEvents_Click(object sender, EventArgs e)
        {
            exportEvents(new ArrayList(listDialupEvents.Items));
        }

        private void exportSelection_Click(object sender, EventArgs e)
        {
            exportEvents(new ArrayList(listDialupEvents.SelectedItems));
        }

        private void contextMenuEvents_Opening(object sender, CancelEventArgs e)
        {
            exportSelection.Enabled = !(listDialupEvents.SelectedItems.Count == 0);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (listDialupEvents.SelectedItems.Count == 0)
            {
                exportEvents(new ArrayList(listDialupEvents.Items));
            }
            else
            {
                exportEvents(new ArrayList(listDialupEvents.SelectedItems));
            }
        }
    }
}