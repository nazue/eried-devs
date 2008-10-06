using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SecureConsoleLauncher.Properties;

namespace SecureConsoleLauncher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            CheckAndRun();
        }

        /// <summary>
        /// Comprueba la contraseña e inicia el programa si fue correcta
        /// </summary>
        private void CheckAndRun()
        {
            String p = textBoxPassword.Text;

            if (p.Trim().Length == 0)
                EmptyPassword();
            else
            {
                if (CheckPassword(p))
                {
                    try
                    {
                        // Ejecutar la aplicación cuando estamos en el escritorio seguro
                        System.Diagnostics.Process.Start(Settings.Default.RunWhenSecure);
                    }
                    catch { }

                    Exit();
                }
                else
                    WrongPassword();
            }
        }

        /// <summary>
        /// Ventana de contraseña incorrecta
        /// </summary>
        private void WrongPassword()
        {
            MessageBox.Show(Resources.Msg_Error_WrongPassword, Resources.Msg_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.textBoxPassword.SelectAll();
        }

        /// <summary>
        /// Ventana de escriba una contraseña 
        /// </summary>
        private void EmptyPassword()
        {
            MessageBox.Show(Resources.Msg_Error_EmptyPassword, Resources.Msg_OK_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.textBoxPassword.SelectAll();
        }


        /// <summary>
        /// Comprueba la contraseña con la guardada en la configuración
        /// </summary>
        /// <param name="p">Contraseña</param>
        /// <returns>Verdadero si la contraseña es correcta</returns>
        private bool CheckPassword(string p)
        {
            return (EncodeString(p) == Settings.Default.PassHash);
        }

        /// <summary>
        /// Retorna el Hash SHA de un string
        /// </summary>
        /// <param name="p">Cadena a codificar</param>
        /// <returns>Codificación</returns>
        public string EncodeString(string p)
        {
            Byte[] original = ASCIIEncoding.Default.GetBytes(p);
            Byte[] encoded = new System.Security.Cryptography.SHA512Managed().ComputeHash(original);

            return BitConverter.ToString(encoded);
        }

        private void linkLabelChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword();
        }

        /// <summary>
        /// Muestra y administra el cambio de contraseña
        /// </summary>
        private void ChangePassword()
        {
            FormChangePass p = new FormChangePass();

            if (p.ShowDialog() == DialogResult.OK)
            {
                if (CheckPassword(p.actualPassword))
                {
                    Settings.Default.PassHash = EncodeString(p.newPassword);
                    Settings.Default.Save();

                    MessageBox.Show(Resources.Msg_OK_PasswordChanged, Resources.Msg_OK_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    WrongPassword();
                }
            }
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            textBoxPassword.Focus();
        }
    }
}