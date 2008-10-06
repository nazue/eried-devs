namespace InterfazTerceraEdad
{
    partial class FormMoney
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
            this.tabControlBrowser = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.checkBoxReportYear = new System.Windows.Forms.CheckBox();
            this.checkBoxReportMonth = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlBrowser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBrowser
            // 
            this.tabControlBrowser.Controls.Add(this.tabPage2);
            this.tabControlBrowser.Controls.Add(this.tabPage3);
            this.tabControlBrowser.Controls.Add(this.tabPage4);
            this.tabControlBrowser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBrowser.HotTrack = true;
            this.tabControlBrowser.Location = new System.Drawing.Point(11, 12);
            this.tabControlBrowser.Name = "tabControlBrowser";
            this.tabControlBrowser.SelectedIndex = 0;
            this.tabControlBrowser.Size = new System.Drawing.Size(1000, 154);
            this.tabControlBrowser.TabIndex = 4;
            this.tabControlBrowser.SelectedIndexChanged += new System.EventHandler(this.tabControlBrowser_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo gasto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar ahora y todos los meses";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(795, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 33);
            this.button4.TabIndex = 10;
            this.button4.Text = "Agregar gasto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(17, 45);
            this.maskedTextBox1.Mask = "$99,999,999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(178, 33);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Comida y alimentación",
            "Entretención",
            "Medicinas",
            "Cuentas: Electricidad",
            "Cuentas: Agua"});
            this.comboBox1.Location = new System.Drawing.Point(201, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba la cantidad del nuevo gasto y seleccione o escriba su descripción:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.maskedTextBox2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 116);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nuevo ingreso";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Agregar ahora y todos los meses";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(17, 45);
            this.maskedTextBox2.Mask = "$99,999,999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(178, 33);
            this.maskedTextBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Agregar ingreso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pensión",
            "Trabajo ocasional",
            "Otros"});
            this.comboBox2.Location = new System.Drawing.Point(201, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(272, 33);
            this.comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escriba la cantidad del nuevo ingreso y seleccione o escriba su descripción:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBoxRange);
            this.tabPage4.Controls.Add(this.checkBoxReportYear);
            this.tabPage4.Controls.Add(this.checkBoxReportMonth);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(992, 116);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Generar informes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Items.AddRange(new object[] {
            "Pensión",
            "Trabajo ocasional",
            "Otros"});
            this.comboBoxRange.Location = new System.Drawing.Point(362, 47);
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(272, 33);
            this.comboBoxRange.TabIndex = 18;
            // 
            // checkBoxReportYear
            // 
            this.checkBoxReportYear.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxReportYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReportYear.Location = new System.Drawing.Point(233, 46);
            this.checkBoxReportYear.Name = "checkBoxReportYear";
            this.checkBoxReportYear.Size = new System.Drawing.Size(123, 32);
            this.checkBoxReportYear.TabIndex = 15;
            this.checkBoxReportYear.Text = "Anual";
            this.checkBoxReportYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxReportYear.UseVisualStyleBackColor = true;
            this.checkBoxReportYear.CheckedChanged += new System.EventHandler(this.checkBoxReportYear_CheckedChanged);
            // 
            // checkBoxReportMonth
            // 
            this.checkBoxReportMonth.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxReportMonth.Checked = true;
            this.checkBoxReportMonth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReportMonth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReportMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxReportMonth.Location = new System.Drawing.Point(17, 45);
            this.checkBoxReportMonth.Name = "checkBoxReportMonth";
            this.checkBoxReportMonth.Size = new System.Drawing.Size(210, 32);
            this.checkBoxReportMonth.TabIndex = 14;
            this.checkBoxReportMonth.Text = "Informe mensual";
            this.checkBoxReportMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxReportMonth.UseVisualStyleBackColor = true;
            this.checkBoxReportMonth.CheckedChanged += new System.EventHandler(this.checkBoxReportMonth_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione un tipo de informe y luego el rango de fechas del mismo:";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(915, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(95, 27);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Cerrar";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(732, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(177, 27);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Imprimir informe";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "+ $600.000 (Ingreso por \"Pensión\", automático mensual)",
            "+ $50.000 (Ingreso por \"Devoluciones\")",
            "- $190.000 (Gasto por \"Arriendo\", automático mensual)",
            "- $20.000 (Gasto por \"Gas liquado\")"});
            this.listBox1.Location = new System.Drawing.Point(11, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1000, 529);
            this.listBox1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gastos e ingresos registrados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(7, 731);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(639, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Puede eliminar un gasto o ingreso manteniendo presionado el botón del ratón sobre" +
                " el mismo.";
            // 
            // FormMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.tabControlBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMoney";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMoney_Load);
            this.tabControlBrowser.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBrowser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxReportYear;
        private System.Windows.Forms.CheckBox checkBoxReportMonth;
        private System.Windows.Forms.ComboBox comboBoxRange;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}