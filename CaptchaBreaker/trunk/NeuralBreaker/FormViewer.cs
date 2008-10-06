using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace NeuralBreaker
{
    public partial class FormViewer : Form
    {
        private ArrayList captchaChars;
        public FormViewer(ArrayList dataToShow)
        {
            captchaChars = dataToShow;
            InitializeComponent();
        }

        private void FormViewer_Load(object sender, EventArgs e)
        {
            // Ajustar entorno a los datos
            numericUpDownChar.Maximum = captchaChars.Count;
            numericUpDownWidth.Maximum = ((String)captchaChars[0]).Length;
            numericUpDownWidth.Value = (decimal)Math.Sqrt((double)numericUpDownWidth.Maximum);

            // Seleccionar el primero
            DisplayCharNumber(numericUpDownChar.Value);
        }

        private void DisplayCharNumber(decimal p)
        {
            String m = "", t = "", d = (String)captchaChars[(int)p - 1];

            while (d.Length > (int)this.numericUpDownWidth.Value)
            {
                t = d.Substring(0,Math.Min(d.Length-1,(int)this.numericUpDownWidth.Value));
                m += t + "\r\n";
                d = d.Substring(t.Length);
            }
            m += d;

            textBoxCharViewer.Text = m;
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            DisplayCharNumber(numericUpDownChar.Value);
        }

        private void numericUpDownChar_ValueChanged(object sender, EventArgs e)
        {
            DisplayCharNumber(numericUpDownChar.Value);
        }
    }
}