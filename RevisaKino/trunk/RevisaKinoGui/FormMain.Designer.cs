namespace RevisaKinoGui
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
            this.maskedTextBoxSorteo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.maskedTextBoxCarton = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelResultados = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSorteo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCarton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNumSorteo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCoincidencias = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPremio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.groupBoxResults.SuspendLayout();
            this.flowLayoutPanelResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxSorteo
            // 
            this.maskedTextBoxSorteo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxSorteo.Location = new System.Drawing.Point(37, 41);
            this.maskedTextBoxSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSorteo.Mask = "99999";
            this.maskedTextBoxSorteo.Name = "maskedTextBoxSorteo";
            this.maskedTextBoxSorteo.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBoxSorteo.TabIndex = 0;
            this.maskedTextBoxSorteo.ValidatingType = typeof(int);
            this.maskedTextBoxSorteo.Enter += new System.EventHandler(this.maskedTextBoxSorteo_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de sorteo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de cartón:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(96, 245);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(129, 44);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Comprobar";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // maskedTextBoxCarton
            // 
            this.maskedTextBoxCarton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCarton.Location = new System.Drawing.Point(37, 95);
            this.maskedTextBoxCarton.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCarton.Mask = "99999999";
            this.maskedTextBoxCarton.Name = "maskedTextBoxCarton";
            this.maskedTextBoxCarton.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBoxCarton.TabIndex = 1;
            this.maskedTextBoxCarton.Enter += new System.EventHandler(this.maskedTextBoxCarton_Enter);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.flowLayoutPanelResultados);
            this.groupBoxResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResults.Location = new System.Drawing.Point(273, 18);
            this.groupBoxResults.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxResults.Size = new System.Drawing.Size(306, 271);
            this.groupBoxResults.TabIndex = 5;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Resultados";
            // 
            // flowLayoutPanelResultados
            // 
            this.flowLayoutPanelResultados.Controls.Add(this.label3);
            this.flowLayoutPanelResultados.Controls.Add(this.labelSorteo);
            this.flowLayoutPanelResultados.Controls.Add(this.label9);
            this.flowLayoutPanelResultados.Controls.Add(this.labelCarton);
            this.flowLayoutPanelResultados.Controls.Add(this.label6);
            this.flowLayoutPanelResultados.Controls.Add(this.labelFecha);
            this.flowLayoutPanelResultados.Controls.Add(this.label5);
            this.flowLayoutPanelResultados.Controls.Add(this.labelNumSorteo);
            this.flowLayoutPanelResultados.Controls.Add(this.label7);
            this.flowLayoutPanelResultados.Controls.Add(this.labelCoincidencias);
            this.flowLayoutPanelResultados.Controls.Add(this.label4);
            this.flowLayoutPanelResultados.Controls.Add(this.labelPremio);
            this.flowLayoutPanelResultados.Controls.Add(this.label10);
            this.flowLayoutPanelResultados.Controls.Add(this.labelMonto);
            this.flowLayoutPanelResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelResultados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelResultados.Location = new System.Drawing.Point(4, 24);
            this.flowLayoutPanelResultados.Name = "flowLayoutPanelResultados";
            this.flowLayoutPanelResultados.Size = new System.Drawing.Size(298, 243);
            this.flowLayoutPanelResultados.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sorteo: ";
            // 
            // labelSorteo
            // 
            this.labelSorteo.AutoSize = true;
            this.flowLayoutPanelResultados.SetFlowBreak(this.labelSorteo, true);
            this.labelSorteo.Location = new System.Drawing.Point(72, 0);
            this.labelSorteo.Name = "labelSorteo";
            this.labelSorteo.Size = new System.Drawing.Size(33, 19);
            this.labelSorteo.TabIndex = 1;
            this.labelSorteo.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cartón:";
            // 
            // labelCarton
            // 
            this.labelCarton.AutoSize = true;
            this.flowLayoutPanelResultados.SetFlowBreak(this.labelCarton, true);
            this.labelCarton.Location = new System.Drawing.Point(68, 19);
            this.labelCarton.Name = "labelCarton";
            this.labelCarton.Size = new System.Drawing.Size(89, 19);
            this.labelCarton.TabIndex = 7;
            this.labelCarton.Text = "0000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.flowLayoutPanelResultados.SetFlowBreak(this.labelFecha, true);
            this.labelFecha.Location = new System.Drawing.Point(61, 38);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(45, 19);
            this.labelFecha.TabIndex = 11;
            this.labelFecha.Text = "0/0/0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Números del boleto:";
            // 
            // labelNumSorteo
            // 
            this.labelNumSorteo.AutoSize = true;
            this.flowLayoutPanelResultados.SetFlowBreak(this.labelNumSorteo, true);
            this.labelNumSorteo.Location = new System.Drawing.Point(3, 76);
            this.labelNumSorteo.Name = "labelNumSorteo";
            this.labelNumSorteo.Size = new System.Drawing.Size(209, 19);
            this.labelNumSorteo.TabIndex = 3;
            this.labelNumSorteo.Text = "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Coincidencias:";
            // 
            // labelCoincidencias
            // 
            this.labelCoincidencias.AutoSize = true;
            this.flowLayoutPanelResultados.SetFlowBreak(this.labelCoincidencias, true);
            this.labelCoincidencias.Location = new System.Drawing.Point(114, 95);
            this.labelCoincidencias.Name = "labelCoincidencias";
            this.labelCoincidencias.Size = new System.Drawing.Size(17, 19);
            this.labelCoincidencias.TabIndex = 5;
            this.labelCoincidencias.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Premio:";
            // 
            // labelPremio
            // 
            this.labelPremio.AutoSize = true;
            this.flowLayoutPanelResultados.SetFlowBreak(this.labelPremio, true);
            this.labelPremio.Location = new System.Drawing.Point(71, 114);
            this.labelPremio.Name = "labelPremio";
            this.labelPremio.Size = new System.Drawing.Size(17, 19);
            this.labelPremio.TabIndex = 9;
            this.labelPremio.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Monto:";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.flowLayoutPanelResultados.SetFlowBreak(this.labelMonto, true);
            this.labelMonto.Location = new System.Drawing.Point(69, 133);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(17, 19);
            this.labelMonto.TabIndex = 13;
            this.labelMonto.Text = "0";
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 10;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 311);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.maskedTextBoxCarton);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxSorteo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Revisa Kino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResults.ResumeLayout(false);
            this.flowLayoutPanelResultados.ResumeLayout(false);
            this.flowLayoutPanelResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxSorteo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCarton;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSorteo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCarton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNumSorteo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCoincidencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPremio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Timer timerAnimation;
    }
}

