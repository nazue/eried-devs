using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LinkCleaner.Properties;
using System.Text.RegularExpressions;

namespace LinkCleaner
{
    public partial class FormMain : Form
    {
        private bool guimode = false;
        private Size prev;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadAppSettings();
        }

        private void LoadAppSettings()
        {
            // Propiedades de la ventana
            this.Left = Settings.Default.win_left;
            this.Top = Settings.Default.win_top;
            this.Width = Settings.Default.win_width;
            this.Height = Settings.Default.win_height;

            this.prev = this.Size;

            this.WindowState = Settings.Default.win_max ? FormWindowState.Maximized : FormWindowState.Normal;

            // Configuración del programa
            this.textBoxUser.Text = Settings.Default.user;
            this.textBoxExclude.Text = Settings.Default.exclude;

            this.checkBoxExclude.Checked = Settings.Default.exclude_check;
            this.textBoxExclude.Enabled = Settings.Default.exclude_check;
            this.checkBoxUser.Checked = Settings.Default.user_check;
            this.textBoxUser.Enabled = Settings.Default.user_check;

            this.textBoxMain.Text = Settings.Default.last;

            // Modo de interfaz
            SwitchGUIMode(Settings.Default.auto);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void CopyToClipboard()
        {
            try
            {
                if (this.textBoxMain.Text.Length > 0)
                {
                    Clipboard.SetText(this.textBoxMain.Text);
                    notifyIconCopy.Visible = true;
                    notifyIconCopy.ShowBalloonTip(5, "Procesador de enlaces", "Los resultados fueron copiados al portapapeles.", ToolTipIcon.Info);
                }
            }
            catch { }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxMain.Clear();
        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxUser.Enabled = checkBoxUser.Checked;
        }

        private void checkBoxExclude_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExclude.Enabled = checkBoxExclude.Checked;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAppSettings();
        }

        private void SaveAppSettings()
        {
            // Propiedades de la ventana
            Settings.Default.win_max = this.WindowState == FormWindowState.Maximized ? true : false;

            if (!Settings.Default.win_max && !this.guimode)
            {
                Settings.Default.win_left = this.Left;
                Settings.Default.win_top = this.Top;

                Settings.Default.win_width = this.Width;
                Settings.Default.win_height = this.Height;
            }

            // Configuración del programa
            Settings.Default.user = this.textBoxUser.Text;
            Settings.Default.exclude = this.textBoxExclude.Text;

            Settings.Default.exclude_check = this.checkBoxExclude.Checked;
            Settings.Default.user_check = this.checkBoxUser.Checked;

            Settings.Default.last = this.textBoxMain.Text;
            Settings.Default.auto = guimode;

            Settings.Default.Save();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            ExtractURL();
        }

        private void ExtractURL()
        {
            String t = "", s = "", conn = "", exep = "";
            Boolean first = true;

            if (checkBoxExclude.Checked)
                exep = textBoxExclude.Text;

            if (checkBoxUser.Checked)
                conn = textBoxUser.Text + "@";

            try
            {
                t = this.textBoxMain.Text;
                Regex regex = new Regex(@"\b(?<protocol>https?|ftp)://(?<domain>[-A-Z0-9.]+)(?<file>/[-A-Z0-9+&@#/%=~_|!:,.;]*)?(?<parameters>\?[-A-Z0-9+&@#/%=~_|!:,.;]*)?", RegexOptions.IgnoreCase);
                Match matchResults = regex.Match(t);
                while (matchResults.Success)
                {
                    if(matchResults.Value.Contains(exep))
                    {
                        s += matchResults.Result(String.Format("{0}$1://{1}$2$3$4",!first ? "\r\n" : "",conn));
                        first = false;
                    }
                    
                    matchResults = matchResults.NextMatch();
                    
                }

                this.textBoxMain.Text = s;
            }
            catch 
            {
                this.textBoxMain.Text = t;
            }

        }

        private void notifyIconCopy_BalloonTipShown(object sender, EventArgs e)
        {
            
        }

        private void notifyIconCopy_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIconCopy.Visible = false;
        }


        private void SwitchGUIMode(bool p)
        {
            this.guimode = p;
            this.FormBorderStyle = p ? FormBorderStyle.FixedSingle : FormBorderStyle.Sizable;
            this.MinimumSize = p ? new Size(0,0) : new Size(470,250);
            this.MaximizeBox = !p;

            if (p)
            {
                prev = this.Size;
                this.Size = new Size(260, 140);
            }
            else
            {
                this.Size = prev;
            }

            this.panelMain.Visible = !p;
            this.panelMini.Visible = p;
            

        }


        private void buttonAutoMini_Click(object sender, EventArgs e)
        {
            SwitchGUIMode(false);
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            SwitchGUIMode(true);
        }

        private void buttonProcessMini_Click(object sender, EventArgs e)
        {
            this.textBoxMain.Clear();
            try
            {
                this.textBoxMain.Text = Clipboard.GetText();
            }
            catch { }
            this.ExtractURL();
            this.CopyToClipboard();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            this.buttonAuto.Enabled = (this.WindowState != FormWindowState.Maximized);
        }
    }
}