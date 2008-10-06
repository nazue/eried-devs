using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InterfazTerceraEdad.Properties;

namespace InterfazTerceraEdad
{
    public partial class FormEditor : Form
    {
        bool leftAlign;

        public FormEditor()
        {
            leftAlign = true;
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SetAlignUI()
        {
            if (leftAlign)
            {
                checkBoxAlignLeft.Checked = true;
                checkBoxAlignCenter.Checked = false;
            }
            else
            {
                checkBoxAlignLeft.Checked = false;
                checkBoxAlignCenter.Checked = true;
            }
            UpdateSelectionFormat();
        }

        private void checkBoxAlignCenter_CheckedChanged(object sender, EventArgs e)
        {
            leftAlign = !checkBoxAlignCenter.Checked;
            SetAlignUI();
        }

        private void checkBoxAlignLeft_CheckedChanged(object sender, EventArgs e)
        {
            leftAlign = checkBoxAlignLeft.Checked;
            SetAlignUI();
        }

        public int EditorFontSize
        {
            get
            {
                int selectedFontSize;
                try
                {
                    selectedFontSize = Convert.ToInt16(this.comboBoxFontSize.Text);
                }
                catch
                {
                    selectedFontSize = 20;
                    this.comboBoxFontSize.Text = "20";
                }

                return selectedFontSize;
            }
        }

        public void UpdateSelectionFormat()
        {
            richTextBoxMain.SelectionFont = new Font(this.lastFontFace, EditorFontSize, EditorFontStyle);
            richTextBoxMain.SelectionAlignment = EditorAlignment;
            this.comboBoxFontFace.Refresh();
        }

        public HorizontalAlignment EditorAlignment
        {
            get
            {
                if (leftAlign)
                    return HorizontalAlignment.Left;
                return HorizontalAlignment.Center;
            }
        }

        public FontStyle EditorFontStyle
        {
            get
            {
                FontStyle output = new FontStyle();
                if(this.checkBoxBold.Checked)
                    output = FontStyle.Bold;

                if (this.checkBoxItalics.Checked)
                    output |= FontStyle.Italic;

                return output;
            }
        }

        private void comboBoxFontFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectionFormat(); 
        }

        private void tabControlBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlBrowser.SelectedIndex == 1)
            {
                richTextBoxMain.Visible = false;
                panelDocs.Visible = true;
                button1.Visible = false;
                button2.Visible = false;

            }
            else
            {
                richTextBoxMain.Visible = true;
                panelDocs.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
            }
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            tabControlBrowser.SelectedIndex = 1;
            tabControlBrowser.SelectedIndex = 0;
            comboBoxFontFace.SelectedIndex = 0;
            comboBoxFontSize.SelectedIndex = 4;
        }

        private void richTextBoxMain_TextChanged(object sender, EventArgs e)
        {
            String t;
            try
            {
                t= richTextBoxMain.Lines[0];
            }
            catch
            {
                t ="";
            }

            if(t.Trim().Length ==0)
                t = "(Sin título)";
            else
                t = t.Substring(0,Math.Min(t.Length,57)) + ((t.Length>57) ? "...": "");

            this.listBoxDocuments.Items[3] = t;
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionFormat();

        }

        private void checkBoxItalics_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionFormat();
        }

        private void comboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectionFormat(); 
        }

        private void comboBoxFontSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                UpdateSelectionFormat(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Clear();
        }

        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxDocuments.SelectedIndex)
            {
                case 0: this.richTextBoxMain.Rtf = Resources.doc_1; break;
                case 1: this.richTextBoxMain.Rtf = Resources.doc_2; break;
                case 2: this.richTextBoxMain.Rtf = Resources.doc_3; break;
                case 3: break;
            }

            this.tabControlBrowser.SelectedIndex = 0;
        }

        private void richTextBoxMain_VisibleChanged(object sender, EventArgs e)
        {
            this.richTextBoxMain.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialogRtf.ShowDialog();
        }

    }
}