namespace IpAnalizer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxMask = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSplitButtonAnalize = new System.Windows.Forms.ToolStripSplitButton();
            this.analizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarHistorialDeAutocompletadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarAnálisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxIp = new System.Windows.Forms.ToolStripTextBox();
            this.lockToolbarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResults.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResults.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.ReadOnly = true;
            this.richTextBoxResults.Size = new System.Drawing.Size(612, 235);
            this.richTextBoxResults.TabIndex = 4;
            this.richTextBoxResults.Text = "";
            this.richTextBoxResults.WordWrap = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBoxResults);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(612, 235);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(612, 260);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxIp,
            this.toolStripLabel2,
            this.toolStripTextBoxMask,
            this.toolStripSplitButtonAnalize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Dirección";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "Máscara";
            // 
            // toolStripTextBoxMask
            // 
            this.toolStripTextBoxMask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBoxMask.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBoxMask.AutoSize = false;
            this.toolStripTextBoxMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxMask.MaxLength = 6;
            this.toolStripTextBoxMask.Name = "toolStripTextBoxMask";
            this.toolStripTextBoxMask.Size = new System.Drawing.Size(80, 21);
            // 
            // toolStripSplitButtonAnalize
            // 
            this.toolStripSplitButtonAnalize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonAnalize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analizeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.opcionesToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripSplitButtonAnalize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripSplitButtonAnalize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonAnalize.Image")));
            this.toolStripSplitButtonAnalize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonAnalize.Name = "toolStripSplitButtonAnalize";
            this.toolStripSplitButtonAnalize.Size = new System.Drawing.Size(69, 22);
            this.toolStripSplitButtonAnalize.Text = "Analizar";
            this.toolStripSplitButtonAnalize.ButtonClick += new System.EventHandler(this.toolStripButtonAnalize_Click);
            // 
            // analizeToolStripMenuItem
            // 
            this.analizeToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analizeToolStripMenuItem.Name = "analizeToolStripMenuItem";
            this.analizeToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.analizeToolStripMenuItem.Text = "Analizar dirección y máscara";
            this.analizeToolStripMenuItem.Click += new System.EventHandler(this.analizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(244, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.closeToolStripMenuItem.Text = "Cerrar";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolbarsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.limpiarHistorialDeAutocompletadoToolStripMenuItem1,
            this.limpiarAnálisisToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // limpiarHistorialDeAutocompletadoToolStripMenuItem1
            // 
            this.limpiarHistorialDeAutocompletadoToolStripMenuItem1.Name = "limpiarHistorialDeAutocompletadoToolStripMenuItem1";
            this.limpiarHistorialDeAutocompletadoToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.limpiarHistorialDeAutocompletadoToolStripMenuItem1.Text = "Limpiar historial de autocompletado";
            // 
            // limpiarAnálisisToolStripMenuItem
            // 
            this.limpiarAnálisisToolStripMenuItem.Name = "limpiarAnálisisToolStripMenuItem";
            this.limpiarAnálisisToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.limpiarAnálisisToolStripMenuItem.Text = "Limpiar análisis";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(250, 6);
            // 
            // toolStripTextBoxIp
            // 
            this.toolStripTextBoxIp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBoxIp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBoxIp.AutoSize = false;
            this.toolStripTextBoxIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxIp.MaxLength = 15;
            this.toolStripTextBoxIp.Name = "toolStripTextBoxIp";
            this.toolStripTextBoxIp.Size = new System.Drawing.Size(120, 21);
            this.toolStripTextBoxIp.Text = global::IpAnalizer.Properties.Settings.Default.ipText;
            // 
            // lockToolbarsToolStripMenuItem
            // 
            this.lockToolbarsToolStripMenuItem.Checked = global::IpAnalizer.Properties.Settings.Default.lockToolbars;
            this.lockToolbarsToolStripMenuItem.CheckOnClick = true;
            this.lockToolbarsToolStripMenuItem.Name = "lockToolbarsToolStripMenuItem";
            this.lockToolbarsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.lockToolbarsToolStripMenuItem.Text = "Bloquear barras de menú";
            this.lockToolbarsToolStripMenuItem.Click += new System.EventHandler(this.lockToolbarsToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 260);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Ip Analizer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMask;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxIp;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonAnalize;
        private System.Windows.Forms.ToolStripMenuItem analizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarHistorialDeAutocompletadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem limpiarAnálisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolbarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;


    }
}

