namespace InterfazTerceraEdad
{
    partial class FormBrowser
    {
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
            this.components = new System.ComponentModel.Container();
            this.webBrowserMain = new System.Windows.Forms.WebBrowser();
            this.tabControlBrowser = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelSearch = new System.Windows.Forms.LinkLabel();
            this.linkLabelFix = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxSearchEngines = new InterfazTerceraEdad.BetterListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxReferenceMode = new InterfazTerceraEdad.BetterListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.timerUrlFinder = new System.Windows.Forms.Timer(this.components);
            this.timerReference = new System.Windows.Forms.Timer(this.components);
            this.timerSearch = new System.Windows.Forms.Timer(this.components);
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panelStartup = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBrowserBorder = new System.Windows.Forms.Panel();
            this.tabControlBrowser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panelStartup.SuspendLayout();
            this.panelBrowserBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserMain
            // 
            this.webBrowserMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMain.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserMain.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMain.Name = "webBrowserMain";
            this.webBrowserMain.Size = new System.Drawing.Size(996, 580);
            this.webBrowserMain.TabIndex = 0;
            this.webBrowserMain.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowserMain_Navigating);
            this.webBrowserMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserMain_DocumentCompleted);
            // 
            // tabControlBrowser
            // 
            this.tabControlBrowser.Controls.Add(this.tabPage2);
            this.tabControlBrowser.Controls.Add(this.tabPage3);
            this.tabControlBrowser.Controls.Add(this.tabPage4);
            this.tabControlBrowser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBrowser.HotTrack = true;
            this.tabControlBrowser.Location = new System.Drawing.Point(12, 12);
            this.tabControlBrowser.Name = "tabControlBrowser";
            this.tabControlBrowser.SelectedIndex = 0;
            this.tabControlBrowser.Size = new System.Drawing.Size(1000, 154);
            this.tabControlBrowser.TabIndex = 1;
            this.tabControlBrowser.SelectedIndexChanged += new System.EventHandler(this.tabControlBrowser_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxURL);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Navegar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.linkLabelSearch);
            this.flowLayoutPanel1.Controls.Add(this.linkLabelFix);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(969, 31);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // linkLabelSearch
            // 
            this.linkLabelSearch.AutoSize = true;
            this.linkLabelSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSearch.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabelSearch.Location = new System.Drawing.Point(3, 0);
            this.linkLabelSearch.Name = "linkLabelSearch";
            this.linkLabelSearch.Size = new System.Drawing.Size(90, 20);
            this.linkLabelSearch.TabIndex = 2;
            this.linkLabelSearch.TabStop = true;
            this.linkLabelSearch.Text = "search_label";
            this.linkLabelSearch.Visible = false;
            this.linkLabelSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSearch_LinkClicked);
            // 
            // linkLabelFix
            // 
            this.linkLabelFix.AutoSize = true;
            this.linkLabelFix.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFix.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabelFix.Location = new System.Drawing.Point(99, 0);
            this.linkLabelFix.Name = "linkLabelFix";
            this.linkLabelFix.Size = new System.Drawing.Size(245, 20);
            this.linkLabelFix.TabIndex = 3;
            this.linkLabelFix.TabStop = true;
            this.linkLabelFix.Text = "¿Quiere que le corrija la ortografía?";
            this.linkLabelFix.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba la dirección web completa, parte o cualquier cosa que recuerde de la mism" +
                "a:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(17, 45);
            this.textBoxURL.MaxLength = 255;
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(768, 33);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxSearchEngines);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 116);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxSearchEngines
            // 
            this.listBoxSearchEngines.FormattingEnabled = true;
            this.listBoxSearchEngines.IntegralHeight = false;
            this.listBoxSearchEngines.ItemHeight = 25;
            this.listBoxSearchEngines.Items.AddRange(new object[] {
            "Google",
            "Msn Search",
            "Altavista",
            "Youtube"});
            this.listBoxSearchEngines.Location = new System.Drawing.Point(589, 45);
            this.listBoxSearchEngines.Name = "listBoxSearchEngines";
            this.listBoxSearchEngines.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxSearchEngines.Size = new System.Drawing.Size(284, 33);
            this.listBoxSearchEngines.TabIndex = 5;
            this.listBoxSearchEngines.Scroll += new InterfazTerceraEdad.BetterListBox.BetterListBoxScrollDelegate(this.listBoxSearchEngines_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escriba lo que busca, puede cambiar el buscador utilizado:\r\n";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(17, 45);
            this.textBoxSearch.MaxLength = 255;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(566, 33);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxReferenceMode);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.textBoxReference);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(992, 116);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Referencia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxReferenceMode
            // 
            this.listBoxReferenceMode.FormattingEnabled = true;
            this.listBoxReferenceMode.IntegralHeight = false;
            this.listBoxReferenceMode.ItemHeight = 25;
            this.listBoxReferenceMode.Items.AddRange(new object[] {
            "Wikipedia en español",
            "Wikipedia en inglés",
            "Definición RAE",
            "Buscar sinónimos",
            "Traducción a inglés",
            "Traducción a español"});
            this.listBoxReferenceMode.Location = new System.Drawing.Point(17, 45);
            this.listBoxReferenceMode.Name = "listBoxReferenceMode";
            this.listBoxReferenceMode.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxReferenceMode.Size = new System.Drawing.Size(284, 33);
            this.listBoxReferenceMode.TabIndex = 4;
            this.listBoxReferenceMode.Scroll += new InterfazTerceraEdad.BetterListBox.BetterListBoxScrollDelegate(this.listBoxReferenceMode_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione un tipo de referencia y luego escriba una palabra o frase:";
            // 
            // textBoxReference
            // 
            this.textBoxReference.Location = new System.Drawing.Point(307, 45);
            this.textBoxReference.MaxLength = 255;
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(576, 33);
            this.textBoxReference.TabIndex = 2;
            this.textBoxReference.TextChanged += new System.EventHandler(this.textBoxReference_TextChanged);
            // 
            // timerUrlFinder
            // 
            this.timerUrlFinder.Interval = 1300;
            this.timerUrlFinder.Tick += new System.EventHandler(this.timerUrlFinder_Tick);
            // 
            // timerReference
            // 
            this.timerReference.Interval = 500;
            this.timerReference.Tick += new System.EventHandler(this.timerReference_Tick);
            // 
            // timerSearch
            // 
            this.timerSearch.Interval = 500;
            this.timerSearch.Tick += new System.EventHandler(this.timerSearch_Tick);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(915, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(95, 27);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Cerrar";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panelStartup
            // 
            this.panelStartup.Controls.Add(this.label6);
            this.panelStartup.Controls.Add(this.label4);
            this.panelStartup.Controls.Add(this.label5);
            this.panelStartup.Location = new System.Drawing.Point(136, 230);
            this.panelStartup.Name = "panelStartup";
            this.panelStartup.Size = new System.Drawing.Size(713, 211);
            this.panelStartup.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(29, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(653, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Para volver al menú principal haga clic en el botón cerrar, ubicado en la esquina" +
                " superior derecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Escriba en el recuadro superior para comenzar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(700, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "_________________________________________________________________________________" +
                "_____";
            // 
            // panelBrowserBorder
            // 
            this.panelBrowserBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBrowserBorder.Controls.Add(this.webBrowserMain);
            this.panelBrowserBorder.Location = new System.Drawing.Point(12, 172);
            this.panelBrowserBorder.Name = "panelBrowserBorder";
            this.panelBrowserBorder.Size = new System.Drawing.Size(1000, 584);
            this.panelBrowserBorder.TabIndex = 4;
            this.panelBrowserBorder.Visible = false;
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelStartup);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.tabControlBrowser);
            this.Controls.Add(this.panelBrowserBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBrowser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBrowser_Load);
            this.tabControlBrowser.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panelStartup.ResumeLayout(false);
            this.panelStartup.PerformLayout();
            this.panelBrowserBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMain;
        private System.Windows.Forms.TabControl tabControlBrowser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerUrlFinder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.Timer timerReference;
        private BetterListBox listBoxReferenceMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private BetterListBox listBoxSearchEngines;
        private System.Windows.Forms.Timer timerSearch;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Panel panelStartup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabelSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabelFix;
        private System.Windows.Forms.Panel panelBrowserBorder;
    }
}