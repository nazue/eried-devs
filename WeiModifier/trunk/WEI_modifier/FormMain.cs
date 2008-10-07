using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using WEI_modifier.Properties;

namespace WEI_modifier
{
    public partial class FormMain : Form
    {
        private double[] indexValue, lastIndexValue;
        private string lastWinSat;
        public FormMain()
        {
            InitializeComponent();
        }

        private void UpdateIndex()
        {
            int i;
            double min = 999;

            for (i = 0; i < indexValue.Length - 1; i++)
                if (indexValue[i] < min)
                    min = indexValue[i];

            indexValue[5] = min;

            index1.Text = AdjustIndex(indexValue[0]);
            index2.Text = AdjustIndex(indexValue[1]);
            index3.Text = AdjustIndex(indexValue[2]);
            index4.Text = AdjustIndex(indexValue[3]);
            index5.Text = AdjustIndex(indexValue[4]);
            index6.Text = AdjustIndex(indexValue[5]);

            trackBar6.Value = (int)indexValue[5];
            buttonSave.Enabled = true;
            buttonRestore.Enabled = true;
        }

        private string AdjustIndex(double v)
        {
            return AdjustIndex(v, ",");
        }

        private string AdjustIndex(double v, string separator)
        {
            string ou;
            ou = (v / 10).ToString();
            ou = (ou.Replace(",", separator)).Replace(".", separator);
            if (ou.Length<=2)
                ou += separator + "0";

            return ou;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            indexValue[0] = trackBar1.Value;
            UpdateIndex();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            indexValue[1] = trackBar2.Value;
            UpdateIndex();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            indexValue[2] = trackBar3.Value;
            UpdateIndex();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            indexValue[3] = trackBar4.Value;
            UpdateIndex();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            indexValue[4] = trackBar5.Value;
            UpdateIndex();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            //indexValue[5] = trackBar6.Value;
            //updateIndex();
        }

        private string FindLastWinSAT()
        {
            try
            {
                string wDir = Environment.GetEnvironmentVariable("SystemRoot"), myDir;
                myDir = wDir + "\\Performance\\WinSAT\\DataStore";

                DirectoryInfo myDir2 = new DirectoryInfo(myDir);
                FileInfo[] myFiles = myDir2.GetFiles("*Assessment*WinSAT.xml");

                string[] filePaths = new string[myFiles.Length];
                int i = 0;
                foreach (FileInfo file in myFiles)
                    filePaths[i++] = file.FullName;

                Array.Sort(filePaths);

                return filePaths[myFiles.Length - 1];
            }
            catch
            {
                return "";
            }
        }

        private void SaveXML()
        {
            try
            {
                // Inicialización
                XmlDocument myXml = new XmlDocument();
                myXml.Load(lastWinSat);

                XmlNode myXmlNode = myXml.DocumentElement;

                foreach (XmlNode node1 in myXmlNode.ChildNodes)
                    foreach (XmlNode node2 in node1.ChildNodes)
                        switch (node2.Name)
                        {
                            // Total
                            case "SystemScore": node2.InnerText = AdjustIndex(indexValue[5], "."); break;

                            // Individuales
                            case "CpuScore": node2.InnerText = AdjustIndex(indexValue[0], "."); break;
                            case "MemoryScore": node2.InnerText = AdjustIndex(indexValue[1], "."); break;
                            case "GraphicsScore": node2.InnerText = AdjustIndex(indexValue[2], "."); break;
                            case "GamingScore": node2.InnerText = AdjustIndex(indexValue[3], "."); break;
                            case "DiskScore": node2.InnerText = AdjustIndex(indexValue[4], "."); break;
                        }

                myXml.Save(lastWinSat);
                buttonSave.Enabled = false;
                buttonRestore.Enabled = true;
            }
            catch
            {
                MessageBox.Show(Resources.SaveErrorText, Resources.SaveErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Ocultar ventana (en caso de que no se ejecute en Vista)
            this.Hide();

            try
            {
                indexValue = new double[6];
                lastIndexValue = new double[6];

                int i;
                for (i = 0; i < indexValue.Length; i++)
                    indexValue[i] = 10;

                LoadXML();
            }
            catch
            {
                MessageBox.Show(Resources.LoadErrorText,Resources.LoadErrorTitle,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        private void LoadXML()
        {
            // Inicialización
            XmlDocument myXml = new XmlDocument();
            lastWinSat = FindLastWinSAT();

            myXml.Load(lastWinSat);

            XmlNode myXmlNode = myXml.DocumentElement;

            foreach (XmlNode node1 in myXmlNode.ChildNodes)
                foreach (XmlNode node2 in node1.ChildNodes)
                    switch (node2.Name)
                    {
                        // Total
                        case "SystemScore": indexValue[5] = Convert.ToDouble(node2.InnerText); break;

                        // Individuales
                        case "CpuScore": indexValue[0] = Convert.ToDouble(node2.InnerText); break;
                        case "MemoryScore": indexValue[1] = Convert.ToDouble(node2.InnerText); break;
                        case "GraphicsScore": indexValue[2] = Convert.ToDouble(node2.InnerText); break;
                        case "GamingScore": indexValue[3] = Convert.ToDouble(node2.InnerText); break;
                        case "DiskScore": indexValue[4] = Convert.ToDouble(node2.InnerText); break;
                    }

            this.Show();
            UpdateIndex();
            UpdateTrackbars();
            buttonSave.Enabled = false;

            // Guardar los datos previos
            for (int i = 0; i < indexValue.Length; i++)
                lastIndexValue[i] = indexValue[i];
        }

        private void UpdateTrackbars()
        {
            trackBar1.Value = (int)indexValue[0];
            trackBar2.Value = (int)indexValue[1];
            trackBar3.Value = (int)indexValue[2];
            trackBar4.Value = (int)indexValue[3];
            trackBar5.Value = (int)indexValue[4];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveXML();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < indexValue.Length; i++)
                indexValue[i] = lastIndexValue[i];

            UpdateTrackbars();
            UpdateIndex();
            SaveXML();
        }
    }
}