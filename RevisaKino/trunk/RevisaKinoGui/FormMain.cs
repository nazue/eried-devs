using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WebQueryLib;
using System.Security.Policy;

namespace RevisaKinoGui
{
    public partial class FormMain : Form
    {
        private int desiredWidth, defaultWidth;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            buttonCheck.Enabled = false;
            
            UpdateKinoInfo();
            buttonCheck.Enabled = true;
        }

        private void UpdateKinoInfo()
        {
            WebQuery w = new WebQuery("http://www.loteria.cl/KinoASP/procesa_consulta_kino.asp?Nconsulta=11&panel=1&email=&onHTTPStatus=%5Btype%20Function%5D&sorteo=%sorteo%&boleto=%boleto%", new string[] { "%sorteo%", "%boleto%" });
            Dictionary<String, String> d = ParseQuery(w.Query(new String[] { maskedTextBoxSorteo.Text, maskedTextBoxCarton.Text }));

            if (d["respuesta"].CompareTo("1") == 0)
            {
                labelSorteo.Text = maskedTextBoxSorteo.Text;
                labelCarton.Text = d["Boleto"];
                labelCoincidencias.Text = Array.FindAll<String>(d["AKino"].Split(','), delegate(String s) { return s.CompareTo("00") != 0; }).Length.ToString();
                labelNumSorteo.Text = d["BolKino"];
                labelPremio.Text = d["Promo"];
                labelMonto.Text = d["Monto"];
                labelFecha.Text = d["Fecha"];
                ChangeGuiMode(false,false);
            }
            else
            {
                ChangeGuiMode(true,false);
            }
        }

        private Dictionary<String, String> ParseQuery(string p)
        {
            Dictionary<String, String> d = new Dictionary<string,string>();
            foreach (String q in p.Split('&'))
            {
                String[] z = q.Split('=');

                if (z.Length == 2)
                    if (z[0].Length > 0)
                        d.Add(z[0].Trim(), z[1].Trim());
            }
            return d;
        }

        private void ChangeGuiMode(Boolean minimized, Boolean quick)
        {
            if (minimized)
                desiredWidth = defaultWidth - 360;
            else
                desiredWidth = defaultWidth;

            groupBoxResults.Visible = !minimized;
            timerAnimation.Enabled = false;

            if (quick)
                this.Width = desiredWidth;
            else
                timerAnimation.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            desiredWidth = this.Width;
            defaultWidth = desiredWidth;
            timerAnimation.Enabled = true;
            ChangeGuiMode(true,true);
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (this.Width == desiredWidth)
                timerAnimation.Enabled = false;
            else
                this.Width += this.Width > desiredWidth ? -20 : 20;
        }

        private void maskedTextBoxSorteo_Enter(object sender, EventArgs e)
        {
            maskedTextBoxSorteo.SelectAll();
        }

        private void maskedTextBoxCarton_Enter(object sender, EventArgs e)
        {
            maskedTextBoxCarton.SelectAll();
        }
    }
}