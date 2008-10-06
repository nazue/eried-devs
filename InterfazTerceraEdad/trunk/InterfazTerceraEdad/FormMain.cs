using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InterfazTerceraEdad.Properties;
using System.Media;

namespace InterfazTerceraEdad
{
    public partial class FormMain : Form
    {
        private Form app_browser, app_editor, app_money, app_mail;
        private SoundPlayer high_freq;
        private int last_nuke;

        public FormMain()
        {
            app_browser = new FormBrowser();
            app_editor = new FormEditor();
            app_money = new FormMoney();
            app_mail = new FormMail();
            high_freq = new SoundPlayer(Resources.high_freq);
            last_nuke = 0;

            InitializeComponent();
        }

        private void pictureBoxEdit_MouseHover(object sender, EventArgs e)
        {
            pictureBoxEdit.Image = Resources.edit_2;
        }

        private void pictureBoxEdit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxEdit.Image = Resources.edit_1;
        }

        private void pictureBoxMail_MouseHover(object sender, EventArgs e)
        {
            pictureBoxMail.Image = Resources.mail_2;
        }

        private void pictureBoxMail_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMail.Image = Resources.mail_1;
        }

        private void pictureBoxMoney_MouseHover(object sender, EventArgs e)
        {
            pictureBoxMoney.Image = Resources.money_2;
        }

        private void pictureBoxMoney_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMoney.Image = Resources.money_1;
        }

        private void pictureBoxBrowser_MouseHover(object sender, EventArgs e)
        {
            pictureBoxBrowser.Image = Resources.browser_2;
        }

        private void pictureBoxBrowser_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBrowser.Image = Resources.browser_1;
        }

        private void pictureBoxOff_MouseHover(object sender, EventArgs e)
        {
            pictureBoxOff.Image = Resources.off_2;
        }

        private void pictureBoxOff_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxOff.Image = Resources.off_1;
        }

        private void pictureBoxNuke_MouseHover(object sender, EventArgs e)
        {
            if (!timerNuke.Enabled) 
                pictureBoxNuke.Image = Resources.nuke_2;
        }

        private void pictureBoxNuke_MouseLeave(object sender, EventArgs e)
        {
            if (!timerNuke.Enabled) 
                pictureBoxNuke.Image = Resources.nuke_1;
        }

        private void pictureBoxOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxBrowser_Click(object sender, EventArgs e)
        {
            app_browser.Show();
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            app_editor.Show();
        }

        private void UpdateClock()
        {
            DateTime actual = DateTime.Now;

            this.labelDateDay.Text = ""+actual.Day;
            String[] Weekdays = { "Domingo","Lunes", "Martes", "Miércoles", "Jueves", "Viernes","Sábado" };
            this.labelDateWeekday.Text = Weekdays[Convert.ToInt16(actual.DayOfWeek)];
            this.labelDateHour.Text = Convert.ToInt16(actual.Hour % 12) + ":" + ((actual.Minute < 10) ? "0" + actual.Minute : ""+ actual.Minute) + " " + ((actual.Hour > 12) ? "PM" : "AM");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void pictureBoxMoney_Click(object sender, EventArgs e)
        {
            app_money.Show();
        }

        private void pictureBoxMail_Click(object sender, EventArgs e)
        {
            app_mail.Show();
        }

        private void pictureBoxNuke_Click(object sender, EventArgs e)
        {
            if (!timerNuke.Enabled)
            {
                last_nuke = 1;
                timerNuke.Start();
                high_freq.Play();
            }
        }

        private void timerNuke_Tick(object sender, EventArgs e)
        {
            if (last_nuke%2==0)
                pictureBoxNuke.Image = Resources.nuke_2;
            else
                pictureBoxNuke.Image = Resources.nuke_1;

            if (last_nuke++ > 9)
            {
                pictureBoxNuke.Image = Resources.nuke_1;
                timerNuke.Stop();
            }
        }



    }
}