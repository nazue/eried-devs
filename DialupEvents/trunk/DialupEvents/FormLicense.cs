using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DialupEvents
{
    public partial class FormLicense : Form
    {
        public FormLicense()
        {
            InitializeComponent();
        }

        private void buttonRejectLicence_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrintLicence_Click(object sender, EventArgs e)
        {
            richTextBoxLicence.SaveFile("LICENSE.rtf");
        }

        private void buttonAcceptLicence_Click(object sender, EventArgs e)
        {
            Application.UserAppDataRegistry.SetValue("LicenseAccepted", 1);
            this.Close();
        }

        private void FormLicense_Load(object sender, EventArgs e)
        {
            this.Text += " " + Application.ProductName;
            richTextBoxLicence.Rtf = Properties.Resources.LICENSE;
        }
    }
}