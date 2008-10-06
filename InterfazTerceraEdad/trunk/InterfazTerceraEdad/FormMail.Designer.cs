namespace InterfazTerceraEdad
{
    partial class FormMail
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
            this.buttonPrintMail = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.tabControlBrowser = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlignCenter = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteMail = new System.Windows.Forms.Button();
            this.tabControlBrowser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrintMail
            // 
            this.buttonPrintMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintMail.Location = new System.Drawing.Point(733, 12);
            this.buttonPrintMail.Name = "buttonPrintMail";
            this.buttonPrintMail.Size = new System.Drawing.Size(177, 27);
            this.buttonPrintMail.TabIndex = 12;
            this.buttonPrintMail.Text = "Imprimir mensaje";
            this.buttonPrintMail.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(916, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(95, 27);
            this.buttonQuit.TabIndex = 11;
            this.buttonQuit.Text = "Cerrar";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
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
            this.tabControlBrowser.Size = new System.Drawing.Size(1000, 205);
            this.tabControlBrowser.TabIndex = 9;
            this.tabControlBrowser.SelectedIndexChanged += new System.EventHandler(this.tabControlBrowser_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo mensaje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 33);
            this.textBox1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(712, 33);
            this.textBox3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Asunto del mensaje:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 121);
            this.button4.TabIndex = 13;
            this.button4.Text = "Enviar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Libreta de direcciones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destinatario del correo:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 167);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Revisar nuevos mensajes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Bienvenido (equipo@gmail.com)",
            "Documentos importantes (otro@gmail.com)"});
            this.listBox1.Location = new System.Drawing.Point(163, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(702, 93);
            this.listBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 121);
            this.button2.TabIndex = 16;
            this.button2.Text = "Volver a comprobar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correos nuevos:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox2);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.checkBoxAlignCenter);
            this.tabPage4.Controls.Add(this.listBox2);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(992, 167);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Todo el correo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(19, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(127, 37);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Ayer";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(19, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 37);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Todo";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlignCenter
            // 
            this.checkBoxAlignCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAlignCenter.Checked = true;
            this.checkBoxAlignCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlignCenter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAlignCenter.Location = new System.Drawing.Point(19, 19);
            this.checkBoxAlignCenter.Name = "checkBoxAlignCenter";
            this.checkBoxAlignCenter.Size = new System.Drawing.Size(127, 37);
            this.checkBoxAlignCenter.TabIndex = 21;
            this.checkBoxAlignCenter.Text = "Sólo hoy";
            this.checkBoxAlignCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAlignCenter.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Items.AddRange(new object[] {
            "¡Hola como estas! (ejemplo@hotmail.com)",
            "Bienvenido (equipo@gmail.com)",
            "Documentos importantes (otro@gmail.com)",
            "Bienvenido de nuevo (equipo@gmail.com)",
            "Otros documentos importantes (otro@gmail.com)"});
            this.listBox2.Location = new System.Drawing.Point(163, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(702, 93);
            this.listBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lista de correos:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 255);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1000, 501);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 121);
            this.button6.TabIndex = 13;
            this.button6.Text = "Enviar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(625, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 33);
            this.button7.TabIndex = 11;
            this.button7.Text = "Libreta de direcciones";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Destinatario del correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cuerpo del mensaje:";
            // 
            // buttonDeleteMail
            // 
            this.buttonDeleteMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMail.Location = new System.Drawing.Point(526, 12);
            this.buttonDeleteMail.Name = "buttonDeleteMail";
            this.buttonDeleteMail.Size = new System.Drawing.Size(177, 27);
            this.buttonDeleteMail.TabIndex = 16;
            this.buttonDeleteMail.Text = "Borrar mensaje";
            this.buttonDeleteMail.UseVisualStyleBackColor = true;
            this.buttonDeleteMail.Visible = false;
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.buttonDeleteMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonPrintMail);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.tabControlBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
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

        private System.Windows.Forms.Button buttonPrintMail;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TabControl tabControlBrowser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAlignCenter;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonDeleteMail;
    }
}