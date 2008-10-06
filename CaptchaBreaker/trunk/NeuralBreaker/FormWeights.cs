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
    public partial class FormWeights : Form
    {
        private ArrayList _matchs;
        public FormWeights(ArrayList matchs)
        {
            _matchs = matchs;
            InitializeComponent();
        }

        private void FormWeights_Load(object sender, EventArgs e)
        {
            this.listViewMatchs.Items.Clear();
            _matchs.Sort();

            foreach (String s in _matchs)
            {
                this.listViewMatchs.Items.Add(new ListViewItem(s.Split(Convert.ToChar("\t"))));
            }
        }
    }
}