namespace Perceptron
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResultFull = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonTrainOnce = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownError = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAlpha = new System.Windows.Forms.NumericUpDown();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxW6 = new System.Windows.Forms.TextBox();
            this.textBoxW5 = new System.Windows.Forms.TextBox();
            this.textBoxW4 = new System.Windows.Forms.TextBox();
            this.textBoxW3 = new System.Windows.Forms.TextBox();
            this.textBoxW2 = new System.Windows.Forms.TextBox();
            this.textBoxW1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxResultFull);
            this.groupBox1.Controls.Add(this.buttonTest);
            this.groupBox1.Controls.Add(this.listBox6);
            this.groupBox1.Controls.Add(this.listBox5);
            this.groupBox1.Controls.Add(this.listBox4);
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testing";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(113, 104);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(36, 27);
            this.textBoxResult.TabIndex = 9;
            this.textBoxResult.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Result:";
            // 
            // textBoxResultFull
            // 
            this.textBoxResultFull.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultFull.Location = new System.Drawing.Point(24, 104);
            this.textBoxResultFull.Name = "textBoxResultFull";
            this.textBoxResultFull.ReadOnly = true;
            this.textBoxResultFull.Size = new System.Drawing.Size(82, 27);
            this.textBoxResultFull.TabIndex = 7;
            this.textBoxResultFull.Text = "0";
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(158, 101);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(82, 30);
            this.buttonTest.TabIndex = 6;
            this.buttonTest.Text = "&Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // listBox6
            // 
            this.listBox6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 18;
            this.listBox6.Items.AddRange(new object[] {
            "0",
            "1"});
            this.listBox6.Location = new System.Drawing.Point(135, 28);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(18, 40);
            this.listBox6.TabIndex = 5;
            // 
            // listBox5
            // 
            this.listBox5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 18;
            this.listBox5.Items.AddRange(new object[] {
            "0",
            "1"});
            this.listBox5.Location = new System.Drawing.Point(113, 28);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(18, 40);
            this.listBox5.TabIndex = 4;
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 18;
            this.listBox4.Items.AddRange(new object[] {
            "0",
            "1"});
            this.listBox4.Location = new System.Drawing.Point(91, 28);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(18, 40);
            this.listBox4.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 18;
            this.listBox3.Items.AddRange(new object[] {
            "0",
            "1"});
            this.listBox3.Location = new System.Drawing.Point(69, 28);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(18, 40);
            this.listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.listBox2.Location = new System.Drawing.Point(47, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(18, 40);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.listBox1.Location = new System.Drawing.Point(25, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(18, 40);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonReset);
            this.groupBox3.Controls.Add(this.labelStatus);
            this.groupBox3.Controls.Add(this.buttonTrainOnce);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDownError);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDownMax);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numericUpDownAlpha);
            this.groupBox3.Controls.Add(this.buttonTrain);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 236);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Training";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(169, 192);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(71, 30);
            this.buttonReset.TabIndex = 21;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(21, 159);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(219, 20);
            this.labelStatus.TabIndex = 20;
            this.labelStatus.Text = "Not trained yet.";
            // 
            // buttonTrainOnce
            // 
            this.buttonTrainOnce.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrainOnce.Location = new System.Drawing.Point(78, 192);
            this.buttonTrainOnce.Name = "buttonTrainOnce";
            this.buttonTrainOnce.Size = new System.Drawing.Size(71, 30);
            this.buttonTrainOnce.TabIndex = 19;
            this.buttonTrainOnce.Text = "&Once";
            this.buttonTrainOnce.UseVisualStyleBackColor = true;
            this.buttonTrainOnce.Click += new System.EventHandler(this.buttonTrainOnce_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Min Error:";
            // 
            // numericUpDownError
            // 
            this.numericUpDownError.DecimalPlaces = 7;
            this.numericUpDownError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.numericUpDownError.Location = new System.Drawing.Point(100, 72);
            this.numericUpDownError.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.numericUpDownError.Name = "numericUpDownError";
            this.numericUpDownError.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownError.TabIndex = 16;
            this.numericUpDownError.Value = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Max Iterations:";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(133, 114);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(101, 27);
            this.numericUpDownMax.TabIndex = 13;
            this.numericUpDownMax.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alpha:";
            // 
            // numericUpDownAlpha
            // 
            this.numericUpDownAlpha.DecimalPlaces = 4;
            this.numericUpDownAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownAlpha.Location = new System.Drawing.Point(78, 29);
            this.numericUpDownAlpha.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
            this.numericUpDownAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(75, 27);
            this.numericUpDownAlpha.TabIndex = 11;
            this.numericUpDownAlpha.Value = new decimal(new int[] {
            100,
            0,
            0,
            196608});
            // 
            // buttonTrain
            // 
            this.buttonTrain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrain.Location = new System.Drawing.Point(24, 192);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(48, 30);
            this.buttonTrain.TabIndex = 10;
            this.buttonTrain.Text = "&Go";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxW6);
            this.groupBox2.Controls.Add(this.textBoxW5);
            this.groupBox2.Controls.Add(this.textBoxW4);
            this.groupBox2.Controls.Add(this.textBoxW3);
            this.groupBox2.Controls.Add(this.textBoxW2);
            this.groupBox2.Controls.Add(this.textBoxW1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 139);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weights";
            // 
            // textBoxW6
            // 
            this.textBoxW6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW6.Location = new System.Drawing.Point(126, 92);
            this.textBoxW6.Name = "textBoxW6";
            this.textBoxW6.ReadOnly = true;
            this.textBoxW6.Size = new System.Drawing.Size(96, 27);
            this.textBoxW6.TabIndex = 12;
            this.textBoxW6.Text = "0.0";
            // 
            // textBoxW5
            // 
            this.textBoxW5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW5.Location = new System.Drawing.Point(126, 59);
            this.textBoxW5.Name = "textBoxW5";
            this.textBoxW5.ReadOnly = true;
            this.textBoxW5.Size = new System.Drawing.Size(96, 27);
            this.textBoxW5.TabIndex = 11;
            this.textBoxW5.Text = "0.0";
            // 
            // textBoxW4
            // 
            this.textBoxW4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW4.Location = new System.Drawing.Point(24, 92);
            this.textBoxW4.Name = "textBoxW4";
            this.textBoxW4.ReadOnly = true;
            this.textBoxW4.Size = new System.Drawing.Size(96, 27);
            this.textBoxW4.TabIndex = 10;
            this.textBoxW4.Text = "0.0";
            // 
            // textBoxW3
            // 
            this.textBoxW3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW3.Location = new System.Drawing.Point(24, 59);
            this.textBoxW3.Name = "textBoxW3";
            this.textBoxW3.ReadOnly = true;
            this.textBoxW3.Size = new System.Drawing.Size(96, 27);
            this.textBoxW3.TabIndex = 9;
            this.textBoxW3.Text = "0.0";
            // 
            // textBoxW2
            // 
            this.textBoxW2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW2.Location = new System.Drawing.Point(126, 26);
            this.textBoxW2.Name = "textBoxW2";
            this.textBoxW2.ReadOnly = true;
            this.textBoxW2.Size = new System.Drawing.Size(96, 27);
            this.textBoxW2.TabIndex = 8;
            this.textBoxW2.Text = "0.0";
            // 
            // textBoxW1
            // 
            this.textBoxW1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW1.Location = new System.Drawing.Point(24, 26);
            this.textBoxW1.Name = "textBoxW1";
            this.textBoxW1.ReadOnly = true;
            this.textBoxW1.Size = new System.Drawing.Size(96, 27);
            this.textBoxW1.TabIndex = 7;
            this.textBoxW1.Text = "0.0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Perceptron network";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResultFull;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.NumericUpDown numericUpDownAlpha;
        private System.Windows.Forms.Button buttonTrainOnce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxW6;
        private System.Windows.Forms.TextBox textBoxW5;
        private System.Windows.Forms.TextBox textBoxW4;
        private System.Windows.Forms.TextBox textBoxW3;
        private System.Windows.Forms.TextBox textBoxW2;
        private System.Windows.Forms.TextBox textBoxW1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonReset;
    }
}

