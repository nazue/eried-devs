using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DialupEvents
{
    public partial class FormCost : Form
    {
        private int _seconds;
        private double _cost;
        
        public FormCost(int totalSeconds, double defaultCost)
        {
            _seconds = Math.Max(totalSeconds,0);
            _cost = Math.Max(defaultCost, 0);

            InitializeComponent();
        }

        private void FormCost_Load(object sender, EventArgs e)
        {
            this.txtTotalSeconds.Text = _seconds + "";
            this.txtCostSecond.Value = Convert.ToDecimal(_cost);
        }

        private void txtCostSecond_ValueChanged(object sender, EventArgs e)
        {
            recalculateCost();
        }

        private void recalculateCost()
        {
            this.txtTotal.Text = Convert.ToDouble(txtCostSecond.Value) * Convert.ToInt32(txtTotalSeconds.Text) + "";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.defaultCost = Convert.ToDouble(txtCostSecond.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void txtCostSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            recalculateCost();
        }
    }
}