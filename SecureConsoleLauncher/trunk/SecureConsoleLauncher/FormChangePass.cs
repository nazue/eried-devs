using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecureConsoleLauncher
{
    public partial class FormChangePass : Form
    {
        public String actualPassword, newPassword;

        public FormChangePass()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxNew1.Text.CompareTo(textBoxNew2.Text) == 0 && textBoxNew1.Text.Length >= 4 && textBoxActual.Text.Length >= 4)
            {
                actualPassword = textBoxActual.Text;
                newPassword = textBoxNew1.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(Properties.Resources.Msg_Error_NewPassword, Properties.Resources.Msg_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}