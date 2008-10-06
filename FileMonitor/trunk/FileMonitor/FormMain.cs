using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Mail;

namespace FileMonitor
{
    public partial class FormMain : Form
    {
        int remainingMins;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialogMonitored.ShowDialog();
            this.textDirectoryMonitored.Text = folderBrowserDialogMonitored.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkAndSend();
        }

        private void checkAndSend()
        {
            try
            {
                DateTime today = DateTime.Now;
                DirectoryInfo monitoredPath = new DirectoryInfo(folderBrowserDialogMonitored.SelectedPath);

                bool isUpdated = false;

                if (monitoredPath.LastWriteTime.Year == today.Year &&
                    monitoredPath.LastWriteTime.Month == today.Month &&
                    monitoredPath.LastWriteTime.Day == today.Day)
                {
                    isUpdated = true;
                }

                MailMessage message = new MailMessage("monitoring@computer.com", this.textBox1.Text);
                message.Subject = "Backup Verification";
                String msg;
                if (isUpdated)
                {
                    msg = "Your backup was succesfull completed today! Enjoy";
                }
                else
                {
                    msg = "Your backup up was not succesfull.";
                }
                message.Body = msg;

                SmtpClient server = new SmtpClient(this.textBox2.Text);
                server.Send(message);
                toolStripStatusLabel1.Text = "Mail alert sended succesfully to " + this.textBox1.Text;
            }
            catch (Exception)
            {
                checkBox1.Checked = false;
                toolStripStatusLabel1.Text = "Error: check mail, smtp server, directory, etc.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingMins--;
            toolStripStatusLabel1.Text = "Monitoring (next check in " + remainingMins + " minutes)";

            if (remainingMins == 0)
            {
                checkAndSend();
                remainingMins = 1440;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                remainingMins = 1440;
                toolStripStatusLabel1.Text = "Monitoring (next check in 1440 minutes)";
            }
            else
            {
                toolStripStatusLabel1.Text = "Not monitoring.";
            }
        }
    }
}