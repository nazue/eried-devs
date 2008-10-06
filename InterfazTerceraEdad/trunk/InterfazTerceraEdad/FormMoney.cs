using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfazTerceraEdad
{
    public partial class FormMoney : Form
    {
        private bool reportYearly;
        
        public FormMoney()
        {
            reportYearly = false;
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormMoney_Load(object sender, EventArgs e)
        {
            SetReportUI();
        }

        private void tabControlBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonPrint.Visible = tabControlBrowser.SelectedIndex == 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SetReportUI()
        {
            if (reportYearly)
            {
                checkBoxReportMonth.Checked = false;
                checkBoxReportYear.Checked = true;

                // Años
                comboBoxRange.Items.Clear();
                comboBoxRange.Items.AddRange(new String[] { "2007", "2006", "2005" });
                comboBoxRange.Text = "(Seleccione el año)";
            }
            else
            {
                checkBoxReportMonth.Checked = true;
                checkBoxReportYear.Checked = false;

                // Mensual
                comboBoxRange.Items.Clear();
                comboBoxRange.Items.AddRange(new String[] { "Noviembre (2007)", "Octubre (2007)", "Septiembre (2007)", "Agosto (2007)", "Julio (2007)", "Junio (2007)" });
                comboBoxRange.Text = "(Seleccione el mes y año)";
            }
        }

        private void checkBoxReportMonth_CheckedChanged(object sender, EventArgs e)
        {
            reportYearly = !checkBoxReportMonth.Checked;
            SetReportUI();
        }

        private void checkBoxReportYear_CheckedChanged(object sender, EventArgs e)
        {
            reportYearly = checkBoxReportYear.Checked;
            SetReportUI();
        }
    }
}