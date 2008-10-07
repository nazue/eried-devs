using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IpAnalizer.Properties;
using System.Collections;

namespace IpAnalizer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButtonAnalize_Click(object sender, EventArgs e)
        {
            AnalizeNow();
        }

        private void AnalizeNow()
        {
            try
            {
                richTextBoxResults.Lines = GetAnalisis(toolStripTextBoxIp.Text, toolStripTextBoxMask.Text);

                if (toolStripTextBoxIp.AutoCompleteCustomSource.IndexOf(toolStripTextBoxIp.Text) == -1)
                    toolStripTextBoxIp.AutoCompleteCustomSource.Add(toolStripTextBoxIp.Text);

                if (toolStripTextBoxMask.AutoCompleteCustomSource.IndexOf(toolStripTextBoxMask.Text) == -1)
                    toolStripTextBoxMask.AutoCompleteCustomSource.Add(toolStripTextBoxMask.Text);
            }
            catch { richTextBoxResults.Text = "Error en las entradas.";  }
        }

        private string[] GetAnalisis(string ip, string mask)
        {
            List<String> s = new List<string>();
            s.Add(String.Format("Dirección ip:\t\t{0}",ip));
            s.Add(String.Format("Dirección en binario:\t{0}",SplitAndJoinAsBin(ip)));
            s.Add(String.Format("Dirección formateada:\t{0}", SplitAndJoinString(SplitAndJoinAsBin(ip),8,".")));
            s.Add(String.Format("Máscara:\t\t\t{0}", mask));
            s.Add(String.Format("Máscara en binario:\t{0}",RepeatAsBin(mask)));
            s.Add(String.Format("Máscara formateada:\t{0}",SplitAndJoinString(RepeatAsBin(mask),8,".")));
            s.Add(String.Format("Máscara real:\t\t{0}",Bin2Dec(SplitAndJoinString(RepeatAsBin(mask),8,"."))));
            s.Add(String.Format("Clase según máscara:\tCLASE {0}", GetMaskClass(SplitAndJoinString(RepeatAsBin(mask), 8, "."))));
            s.Add(String.Format("Subredes posibles:\t{0}", Convert.ToInt64("0" + GetSubnetworks(GetLastBitsByClassName(RepeatAsBin(mask), GetMaskClass(SplitAndJoinString(RepeatAsBin(mask), 8, "."))))[0], 2)));
            s.Add(String.Format("Hosts posibles:\t\t{0}, menos 2 reservadas", Convert.ToInt64("0" + GetSubnetworks(RepeatAsBin(mask))[1].Replace('0', '1'), 2)));

            return s.ToArray();
        }

        private string GetMaskClass(string p)
        {
            String[] s = p.Split('.'), classes = { "A","B","C" } ;


            for (int i = 1; i < s.Length; i++)
                if (s[i].ToCharArray()[0] == '0')
                    return classes[i - 1];

            return "C";
        }

        private string SplitAndJoinAsBin(string ip)
        {
            String salida = "";

            foreach (String s in ip.Split('.'))
                salida += Dec2Bin(s).PadLeft(8,'0');

            return salida;
        }

        string DecimalToBase(int iDec, int numbase)
        {
            const int base10 = 10;
            char[] cHexa = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            int[] iHexaNumeric = new int[] { 10, 11, 12, 13, 14, 15 };
            int[] iHexaIndices = new int[] { 0, 1, 2, 3, 4, 5 };
            //const int asciiDiff = 48;

            string strBin = "";
            int[] result = new int[32];
            int MaxBit = 32;
            for (; iDec > 0; iDec /= numbase)
            {
                int rem = iDec % numbase;
                result[--MaxBit] = rem;
            }
            for (int i = 0; i < result.Length; i++)
                if ((int)result.GetValue(i) >= base10)
                    strBin += cHexa[(int)result.GetValue(i) % base10];
                else
                    strBin += result.GetValue(i);
            strBin = strBin.TrimStart(new char[] { '0' });
            return strBin;
        }

        private string Dec2Bin(string s)
        {
            return "" + DecimalToBase(Convert.ToInt16(s), 2);
        }

        private string[] GetSubnetworks(string p)
        {
            return String.Format("1{0}0",p).Split(new String[] {"10"},StringSplitOptions.None);
        }

        private string GetLastBitsByClassName(string p, string className)
        {
            int n = 16;
            switch (className)
            {
                case "A": n = 32; break;
                case "B": n = 24; break;
            } 

            return p.Substring(p.Length - n, n);
        }

        private string Bin2Dec(string p)
        {
            String o = "";

            foreach (String s in p.Split('.'))
                o += Convert.ToInt16(s, 2) + ".";

            return o.Substring(0, o.Length - 1);
        }

        private string SplitAndJoinString(string p, int l,string separator)
        {
            String s = "";

            for (int i = 0; i < p.Length / l; i++)
                s += p.Substring(i * l, l) + separator;

            return s.Substring(0,s.Length-1);
        }

        private string RepeatAsBin(string mask)
        {
            int n = Convert.ToInt16(mask);
            return new String('1', n) + new String('0', 32-n);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void analizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalizeNow();
        }

        private void lockToolbarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockToolbars();
        }

        private void lockToolbars()
        {
            toolStrip1.GripStyle = lockToolbarsToolStripMenuItem.Checked ? ToolStripGripStyle.Hidden : ToolStripGripStyle.Visible;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            updateGui();
            toolStripTextBoxIp.Focus();
        }

        private void updateGui()
        {
            lockToolbars();

            // Elementos de autocompletado
            AutoCompleteStringCollection ip = new AutoCompleteStringCollection();
            AutoCompleteStringCollection mask = new AutoCompleteStringCollection();
            
            if(Settings.Default.ipAutocomplete != null)
                foreach (object s in Settings.Default.ipAutocomplete)
                    ip.Add((String)s);

            if (Settings.Default.maskAutocomplete != null)
                foreach (object s in Settings.Default.maskAutocomplete)
                    mask.Add((String)s);

            toolStripTextBoxIp.AutoCompleteCustomSource = ip;
            toolStripTextBoxMask.AutoCompleteCustomSource = mask;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ocultar la ventana para no producir un retardo
            this.Hide();
            Application.DoEvents();

            Settings.Default.ipAutocomplete = new ArrayList();
            Settings.Default.maskAutocomplete = new ArrayList();

            foreach (String s in toolStripTextBoxIp.AutoCompleteCustomSource)
                Settings.Default.ipAutocomplete.Add(s);

            foreach (String s in toolStripTextBoxMask.AutoCompleteCustomSource)
                Settings.Default.maskAutocomplete.Add(s);

            Settings.Default.Save();
        }

        private void limpiarHistorialDeAutocompletadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripTextBoxIp.AutoCompleteCustomSource.Clear();
            toolStripTextBoxMask.AutoCompleteCustomSource.Clear();
        }

        private void limpiarAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();
        }
    }
}