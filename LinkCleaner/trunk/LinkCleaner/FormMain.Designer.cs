namespace LinkCleaner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonClean = new System.Windows.Forms.Button();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.notifyIconCopy = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBoxExclude = new System.Windows.Forms.TextBox();
            this.checkBoxExclude = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.panelMini = new System.Windows.Forms.Panel();
            this.buttonAutoMini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProcessMini = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelMini.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClean
            // 
            this.buttonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.Location = new System.Drawing.Point(11, 334);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(107, 29);
            this.buttonClean.TabIndex = 0;
            this.buttonClean.Text = "Procesar";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMain.Location = new System.Drawing.Point(11, 12);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMain.Size = new System.Drawing.Size(428, 261);
            this.textBoxMain.TabIndex = 1;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(369, 334);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(70, 29);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copiar";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxUser.AutoSize = true;
            this.checkBoxUser.Location = new System.Drawing.Point(11, 281);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(204, 17);
            this.checkBoxUser.TabIndex = 3;
            this.checkBoxUser.Text = "Añadir la cadena de usuario al limpiar:";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            this.checkBoxUser.CheckedChanged += new System.EventHandler(this.checkBoxUser_CheckedChanged);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxUser.Location = new System.Drawing.Point(236, 279);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(201, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // notifyIconCopy
            // 
            this.notifyIconCopy.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconCopy.Icon")));
            this.notifyIconCopy.BalloonTipClosed += new System.EventHandler(this.notifyIconCopy_BalloonTipClosed);
            this.notifyIconCopy.BalloonTipShown += new System.EventHandler(this.notifyIconCopy_BalloonTipShown);
            // 
            // textBoxExclude
            // 
            this.textBoxExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxExclude.Location = new System.Drawing.Point(236, 302);
            this.textBoxExclude.Name = "textBoxExclude";
            this.textBoxExclude.Size = new System.Drawing.Size(201, 20);
            this.textBoxExclude.TabIndex = 6;
            // 
            // checkBoxExclude
            // 
            this.checkBoxExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxExclude.AutoSize = true;
            this.checkBoxExclude.Location = new System.Drawing.Point(11, 304);
            this.checkBoxExclude.Name = "checkBoxExclude";
            this.checkBoxExclude.Size = new System.Drawing.Size(219, 17);
            this.checkBoxExclude.TabIndex = 5;
            this.checkBoxExclude.Text = "Sólo conservar cadenas que contengan:";
            this.checkBoxExclude.UseVisualStyleBackColor = true;
            this.checkBoxExclude.CheckedChanged += new System.EventHandler(this.checkBoxExclude_CheckedChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(293, 334);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 29);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Borrar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonAuto);
            this.panelMain.Controls.Add(this.textBoxMain);
            this.panelMain.Controls.Add(this.buttonClean);
            this.panelMain.Controls.Add(this.buttonClear);
            this.panelMain.Controls.Add(this.buttonCopy);
            this.panelMain.Controls.Add(this.textBoxExclude);
            this.panelMain.Controls.Add(this.checkBoxUser);
            this.panelMain.Controls.Add(this.checkBoxExclude);
            this.panelMain.Controls.Add(this.textBoxUser);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(451, 385);
            this.panelMain.TabIndex = 9;
            // 
            // buttonAuto
            // 
            this.buttonAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAuto.Location = new System.Drawing.Point(123, 334);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(107, 29);
            this.buttonAuto.TabIndex = 9;
            this.buttonAuto.Text = "Modo automático";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // panelMini
            // 
            this.panelMini.Controls.Add(this.buttonAutoMini);
            this.panelMini.Controls.Add(this.label1);
            this.panelMini.Controls.Add(this.buttonProcessMini);
            this.panelMini.Location = new System.Drawing.Point(6, 9);
            this.panelMini.Name = "panelMini";
            this.panelMini.Size = new System.Drawing.Size(240, 92);
            this.panelMini.TabIndex = 10;
            // 
            // buttonAutoMini
            // 
            this.buttonAutoMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAutoMini.Location = new System.Drawing.Point(164, 60);
            this.buttonAutoMini.Name = "buttonAutoMini";
            this.buttonAutoMini.Size = new System.Drawing.Size(70, 29);
            this.buttonAutoMini.TabIndex = 10;
            this.buttonAutoMini.Text = "Manual";
            this.buttonAutoMini.UseVisualStyleBackColor = true;
            this.buttonAutoMini.Click += new System.EventHandler(this.buttonAutoMini_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presione procesar para tomar el contenido del portapapeles, limpiar los enlaces y" +
                " copiar el contenido nuevamente al portapapeles.";
            // 
            // buttonProcessMini
            // 
            this.buttonProcessMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcessMini.Location = new System.Drawing.Point(3, 60);
            this.buttonProcessMini.Name = "buttonProcessMini";
            this.buttonProcessMini.Size = new System.Drawing.Size(92, 29);
            this.buttonProcessMini.TabIndex = 0;
            this.buttonProcessMini.Text = "Procesar";
            this.buttonProcessMini.UseVisualStyleBackColor = true;
            this.buttonProcessMini.Click += new System.EventHandler(this.buttonProcessMini_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 385);
            this.Controls.Add(this.panelMini);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "FormMain";
            this.Text = "Procesador de enlaces";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelMini.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.NotifyIcon notifyIconCopy;
        private System.Windows.Forms.TextBox textBoxExclude;
        private System.Windows.Forms.CheckBox checkBoxExclude;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProcessMini;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonAutoMini;
    }
}

