using System.Windows.Forms;
using System.Drawing;
using System;
namespace InterfazTerceraEdad
{
    partial class FormEditor
    {

        public String lastFontFace;
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.buttonQuit = new System.Windows.Forms.Button();
            this.tabControlBrowser = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxAlignCenter = new System.Windows.Forms.CheckBox();
            this.checkBoxAlignLeft = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxItalics = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.comboBoxFontFace = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.panelDocs = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxDocuments = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialogRtf = new System.Windows.Forms.PrintDialog();
            this.tabControlBrowser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelDocs.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(915, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(95, 27);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Cerrar";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // tabControlBrowser
            // 
            this.tabControlBrowser.Controls.Add(this.tabPage2);
            this.tabControlBrowser.Controls.Add(this.tabPage3);
            this.tabControlBrowser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBrowser.HotTrack = true;
            this.tabControlBrowser.Location = new System.Drawing.Point(12, 12);
            this.tabControlBrowser.Name = "tabControlBrowser";
            this.tabControlBrowser.SelectedIndex = 0;
            this.tabControlBrowser.Size = new System.Drawing.Size(1000, 154);
            this.tabControlBrowser.TabIndex = 3;
            this.tabControlBrowser.SelectedIndexChanged += new System.EventHandler(this.tabControlBrowser_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxAlignCenter);
            this.tabPage2.Controls.Add(this.checkBoxAlignLeft);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.checkBoxItalics);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBoxFontSize);
            this.tabPage2.Controls.Add(this.checkBoxBold);
            this.tabPage2.Controls.Add(this.comboBoxFontFace);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlignCenter
            // 
            this.checkBoxAlignCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAlignCenter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAlignCenter.Location = new System.Drawing.Point(848, 43);
            this.checkBoxAlignCenter.Name = "checkBoxAlignCenter";
            this.checkBoxAlignCenter.Size = new System.Drawing.Size(123, 51);
            this.checkBoxAlignCenter.TabIndex = 13;
            this.checkBoxAlignCenter.Text = "Centrado";
            this.checkBoxAlignCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAlignCenter.UseVisualStyleBackColor = true;
            this.checkBoxAlignCenter.CheckedChanged += new System.EventHandler(this.checkBoxAlignCenter_CheckedChanged);
            // 
            // checkBoxAlignLeft
            // 
            this.checkBoxAlignLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAlignLeft.Checked = true;
            this.checkBoxAlignLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlignLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxAlignLeft.Image")));
            this.checkBoxAlignLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxAlignLeft.Location = new System.Drawing.Point(706, 43);
            this.checkBoxAlignLeft.Name = "checkBoxAlignLeft";
            this.checkBoxAlignLeft.Size = new System.Drawing.Size(136, 51);
            this.checkBoxAlignLeft.TabIndex = 12;
            this.checkBoxAlignLeft.Text = "Izquierda";
            this.checkBoxAlignLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlignLeft.UseVisualStyleBackColor = true;
            this.checkBoxAlignLeft.CheckedChanged += new System.EventHandler(this.checkBoxAlignLeft_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alinear párrafo:";
            // 
            // checkBoxItalics
            // 
            this.checkBoxItalics.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxItalics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItalics.Location = new System.Drawing.Point(584, 43);
            this.checkBoxItalics.Name = "checkBoxItalics";
            this.checkBoxItalics.Size = new System.Drawing.Size(95, 51);
            this.checkBoxItalics.TabIndex = 10;
            this.checkBoxItalics.Text = "Cursiva";
            this.checkBoxItalics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxItalics.UseVisualStyleBackColor = true;
            this.checkBoxItalics.CheckedChanged += new System.EventHandler(this.checkBoxItalics_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Características:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tamaño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de letra:";
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.ItemHeight = 37;
            this.comboBoxFontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "20",
            "24",
            "36",
            "48"});
            this.comboBoxFontSize.Location = new System.Drawing.Point(327, 45);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(129, 45);
            this.comboBoxFontSize.TabIndex = 6;
            this.comboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontSize_SelectedIndexChanged);
            this.comboBoxFontSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxFontSize_KeyUp);
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBold.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBold.Location = new System.Drawing.Point(489, 43);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(89, 51);
            this.checkBoxBold.TabIndex = 5;
            this.checkBoxBold.Text = "Negrita";
            this.checkBoxBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBold.UseVisualStyleBackColor = true;
            this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
            // 
            // comboBoxFontFace
            // 
            this.comboBoxFontFace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxFontFace.DropDownHeight = 800;
            this.comboBoxFontFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontFace.DropDownWidth = 300;
            this.comboBoxFontFace.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFontFace.FormattingEnabled = true;
            this.comboBoxFontFace.IntegralHeight = false;
            this.comboBoxFontFace.ItemHeight = 39;
            this.comboBoxFontFace.Items.AddRange(new object[] {
            "Arial",
            "Comic Sans",
            "Courier New",
            "Georgia",
            "Tahoma",
            "Times New Roman",
            "Verdana"});
            this.comboBoxFontFace.Location = new System.Drawing.Point(17, 45);
            this.comboBoxFontFace.Name = "comboBoxFontFace";
            this.comboBoxFontFace.Size = new System.Drawing.Size(304, 45);
            this.comboBoxFontFace.TabIndex = 1;
            this.comboBoxFontFace.TabStop = false;
            this.comboBoxFontFace.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItemHandler);
            this.comboBoxFontFace.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontFace_SelectedIndexChanged);
            this.comboBoxFontFace.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MeasureItemHandler);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 116);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Archivador";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escriba el título o parte del texto que busca:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(17, 45);
            this.textBoxSearch.MaxLength = 255;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(895, 33);
            this.textBoxSearch.TabIndex = 2;
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMain.HideSelection = false;
            this.richTextBoxMain.Location = new System.Drawing.Point(12, 173);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(996, 583);
            this.richTextBoxMain.TabIndex = 0;
            this.richTextBoxMain.Text = "";
            this.richTextBoxMain.Visible = false;
            this.richTextBoxMain.VisibleChanged += new System.EventHandler(this.richTextBoxMain_VisibleChanged);
            this.richTextBoxMain.TextChanged += new System.EventHandler(this.richTextBoxMain_TextChanged);
            // 
            // panelDocs
            // 
            this.panelDocs.Controls.Add(this.label6);
            this.panelDocs.Controls.Add(this.listBoxDocuments);
            this.panelDocs.Location = new System.Drawing.Point(1, 169);
            this.panelDocs.Name = "panelDocs";
            this.panelDocs.Size = new System.Drawing.Size(1022, 605);
            this.panelDocs.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(853, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Haga clic en la lista para abrir un documento. Puede buscar rápidamente usando el" +
                " campo superior.";
            // 
            // listBoxDocuments
            // 
            this.listBoxDocuments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDocuments.FormattingEnabled = true;
            this.listBoxDocuments.ItemHeight = 25;
            this.listBoxDocuments.Items.AddRange(new object[] {
            "Lista para el supermercado",
            "Medicina con Receta Medicinas Comunes usadas para Tratar la Enfermedad Cardíaca",
            "Receta: Arroz con carne",
            "(Sin título)"});
            this.listBoxDocuments.Location = new System.Drawing.Point(11, 54);
            this.listBoxDocuments.Name = "listBoxDocuments";
            this.listBoxDocuments.Size = new System.Drawing.Size(996, 529);
            this.listBoxDocuments.TabIndex = 5;
            this.listBoxDocuments.SelectedIndexChanged += new System.EventHandler(this.listBoxDocuments_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(732, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Imprimir documento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(526, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Borrar documento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialogRtf
            // 
            this.printDialogRtf.UseEXDialog = true;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelDocs);
            this.Controls.Add(this.richTextBoxMain);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.tabControlBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormEditor_Load);
            this.tabControlBrowser.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelDocs.ResumeLayout(false);
            this.panelDocs.PerformLayout();
            this.ResumeLayout(false);

        }

        private void DrawItemHandler(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            String fontName = "(Desconocida)";
            String fontFace = "Arial";

            switch (e.Index)
            {
                case 0: fontName = "Arial"; fontFace = fontName; break;
                case 1: fontName = "Comic Sans MS"; fontFace = fontName; break;
                case 2: fontName = "Courier New"; fontFace = fontName; break;
                case 3: fontName = "Georgia"; fontFace = fontName; break;
                case 4: fontName = "Tahoma"; fontFace = fontName; break;
                case 5: fontName = "Times New Roman"; fontFace = fontName; break;
                case 6: fontName = "Verdana"; fontFace = fontName; break;

            }
            lastFontFace = fontFace;
            Font currentFont = new Font(fontFace, 22, this.EditorFontStyle);

            float xpos = e.Bounds.X;
            if (this.EditorAlignment == HorizontalAlignment.Center)
            {
                xpos += e.Bounds.Width / 2;
                xpos -= e.Graphics.MeasureString(fontName, currentFont).Width / 2;
                //fontName.Length;
            }

            e.Graphics.DrawString(fontName, currentFont, new SolidBrush(Color.Black), xpos, e.Bounds.Y);
            //((ComboBox)sender).Font = currentFont;
        }

        private void MeasureItemHandler(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 39;
        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TabControl tabControlBrowser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.ComboBox comboBoxFontFace;
        private System.Windows.Forms.CheckBox checkBoxAlignCenter;
        private System.Windows.Forms.CheckBox checkBoxAlignLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxItalics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private RichTextBox richTextBoxMain;
        private Panel panelDocs;
        private ListBox listBoxDocuments;
        private Label label6;
        private Button button1;
        private Button button2;
        private PrintDialog printDialogRtf;
    }
}