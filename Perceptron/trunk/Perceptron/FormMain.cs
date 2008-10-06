using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Perceptron.Properties;

namespace Perceptron
{
    public partial class FormMain : Form
    {
        ArrayList data;
        Neural neural;

        public FormMain()
        {
            data = new ArrayList();

            // Cargar la lista de pruebas conocidas
            LoadSampleData(data);
            neural = new Neural(data);

            InitializeComponent();
        }

        /// <summary>
        /// Carga una colección de pruebas y resultados
        /// </summary>
        /// <param name="destination">Lista de destino</param>
        private void LoadSampleData(ArrayList destination)
        {
            String _data = Resources.Sample;
            destination.Clear();

            foreach (String s in _data.Split(';'))
            {
                String[] _sub = s.Split('=');
                String[] _temp = _sub[0].Split(',');

                int[] _idata = new int[_temp.Length]; int i = 0;

                foreach (String u in _temp)
                    _idata[i++] = Convert.ToInt16(u);

                destination.Add(new TestCase(_idata, Convert.ToInt16(_sub[1])));
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            int[] testData = new int[6];
            testData[0] = Convert.ToInt16(this.listBox1.SelectedIndex);
            testData[1] = Convert.ToInt16(this.listBox2.SelectedIndex);
            testData[2] = Convert.ToInt16(this.listBox3.SelectedIndex);
            testData[3] = Convert.ToInt16(this.listBox4.SelectedIndex);
            testData[4] = Convert.ToInt16(this.listBox5.SelectedIndex);
            testData[5] = Convert.ToInt16(this.listBox6.SelectedIndex);

            this.textBoxResultFull.Text = neural.Test(testData) + "";
            this.textBoxResult.Text =  neural.Eval(testData) + "";

        }

        private void Iterate(int t)
        {
            this.labelStatus.Text = "Iterating...";
            Application.DoEvents();

            int i = neural.Train(Convert.ToDouble(this.numericUpDownAlpha.Value),
                Convert.ToDouble(this.numericUpDownError.Value), t);

            if (i <= 0)
                this.labelStatus.Text = "No more iterations needed.";
            else
                this.labelStatus.Text = "Iterated " + i + " time(s).";

            UpdateWeights();
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            Iterate(Convert.ToInt32(this.numericUpDownMax.Value));
        }

        private void UpdateWeights()
        {
            this.textBoxW1.Text = Math.Round(neural.GetWeight(0),9) + "";
            this.textBoxW2.Text = Math.Round(neural.GetWeight(1),9) + "";
            this.textBoxW3.Text = Math.Round(neural.GetWeight(2),9) + "";
            this.textBoxW4.Text = Math.Round(neural.GetWeight(3),9) + "";
            this.textBoxW5.Text = Math.Round(neural.GetWeight(4),9) + "";
            this.textBoxW6.Text = Math.Round(neural.GetWeight(5), 9) + "";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.listBox1.SelectedIndex = 0;
            this.listBox2.SelectedIndex = 0;
            this.listBox3.SelectedIndex = 0;
            this.listBox4.SelectedIndex = 0;
            this.listBox5.SelectedIndex = 0;
            this.listBox6.SelectedIndex = 0;

            UpdateWeights();
        }

        private void buttonTrainOnce_Click(object sender, EventArgs e)
        {
            Iterate(1);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            neural.Reset();
            UpdateWeights();
        }

 

    }
}