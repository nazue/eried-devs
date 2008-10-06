namespace InterfazTerceraEdad
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
            this.toolTipOff = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxOff = new System.Windows.Forms.PictureBox();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxMoney = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrowser = new System.Windows.Forms.PictureBox();
            this.pictureBoxMail = new System.Windows.Forms.PictureBox();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.toolTipNuke = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxNuke = new System.Windows.Forms.PictureBox();
            this.labelDateWeekday = new System.Windows.Forms.Label();
            this.labelDateDay = new System.Windows.Forms.Label();
            this.labelDateHour = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.toolTipDateHour = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.timerNuke = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipOff
            // 
            this.toolTipOff.IsBalloon = true;
            this.toolTipOff.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipOff.ToolTipTitle = "Finalizar sesión";
            // 
            // pictureBoxOff
            // 
            this.pictureBoxOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOff.Image = global::InterfazTerceraEdad.Properties.Resources.off_1;
            this.pictureBoxOff.Location = new System.Drawing.Point(815, 0);
            this.pictureBoxOff.Name = "pictureBoxOff";
            this.pictureBoxOff.Size = new System.Drawing.Size(155, 131);
            this.pictureBoxOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOff.TabIndex = 7;
            this.pictureBoxOff.TabStop = false;
            this.toolTipOff.SetToolTip(this.pictureBoxOff, "Cierra el programa y finaliza su sesión");
            this.pictureBoxOff.MouseLeave += new System.EventHandler(this.pictureBoxOff_MouseLeave);
            this.pictureBoxOff.Click += new System.EventHandler(this.pictureBoxOff_Click);
            this.pictureBoxOff.MouseHover += new System.EventHandler(this.pictureBoxOff_MouseHover);
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutoPopDelay = 10000;
            this.toolTipInfo.InitialDelay = 2000;
            this.toolTipInfo.IsBalloon = true;
            this.toolTipInfo.ReshowDelay = 2000;
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo.ToolTipTitle = "¿Desea usar esta aplicación?";
            // 
            // pictureBoxMoney
            // 
            this.pictureBoxMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMoney.Image = global::InterfazTerceraEdad.Properties.Resources.money_1;
            this.pictureBoxMoney.Location = new System.Drawing.Point(437, 45);
            this.pictureBoxMoney.Name = "pictureBoxMoney";
            this.pictureBoxMoney.Size = new System.Drawing.Size(296, 339);
            this.pictureBoxMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMoney.TabIndex = 6;
            this.pictureBoxMoney.TabStop = false;
            this.toolTipInfo.SetToolTip(this.pictureBoxMoney, "Si hace clic, se abrirá el Administrador de cuentas");
            this.pictureBoxMoney.MouseLeave += new System.EventHandler(this.pictureBoxMoney_MouseLeave);
            this.pictureBoxMoney.Click += new System.EventHandler(this.pictureBoxMoney_Click);
            this.pictureBoxMoney.MouseHover += new System.EventHandler(this.pictureBoxMoney_MouseHover);
            // 
            // pictureBoxBrowser
            // 
            this.pictureBoxBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBrowser.Image = global::InterfazTerceraEdad.Properties.Resources.browser_1;
            this.pictureBoxBrowser.Location = new System.Drawing.Point(437, 384);
            this.pictureBoxBrowser.Name = "pictureBoxBrowser";
            this.pictureBoxBrowser.Size = new System.Drawing.Size(296, 327);
            this.pictureBoxBrowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBrowser.TabIndex = 5;
            this.pictureBoxBrowser.TabStop = false;
            this.toolTipInfo.SetToolTip(this.pictureBoxBrowser, "Si hace clic, se abrirá el Navegador de Internet");
            this.pictureBoxBrowser.MouseLeave += new System.EventHandler(this.pictureBoxBrowser_MouseLeave);
            this.pictureBoxBrowser.Click += new System.EventHandler(this.pictureBoxBrowser_Click);
            this.pictureBoxBrowser.MouseHover += new System.EventHandler(this.pictureBoxBrowser_MouseHover);
            // 
            // pictureBoxMail
            // 
            this.pictureBoxMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMail.Image = global::InterfazTerceraEdad.Properties.Resources.mail_1;
            this.pictureBoxMail.Location = new System.Drawing.Point(44, 385);
            this.pictureBoxMail.Name = "pictureBoxMail";
            this.pictureBoxMail.Size = new System.Drawing.Size(282, 327);
            this.pictureBoxMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMail.TabIndex = 4;
            this.pictureBoxMail.TabStop = false;
            this.toolTipInfo.SetToolTip(this.pictureBoxMail, "Si hace clic, se abrirá el Correo electrónico");
            this.pictureBoxMail.MouseLeave += new System.EventHandler(this.pictureBoxMail_MouseLeave);
            this.pictureBoxMail.Click += new System.EventHandler(this.pictureBoxMail_Click);
            this.pictureBoxMail.MouseHover += new System.EventHandler(this.pictureBoxMail_MouseHover);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::InterfazTerceraEdad.Properties.Resources.edit_1;
            this.pictureBoxEdit.Location = new System.Drawing.Point(44, 45);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(282, 339);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEdit.TabIndex = 3;
            this.pictureBoxEdit.TabStop = false;
            this.toolTipInfo.SetToolTip(this.pictureBoxEdit, "Si hace clic, se abrirá el Editor de documentos");
            this.pictureBoxEdit.MouseLeave += new System.EventHandler(this.pictureBoxEdit_MouseLeave);
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            this.pictureBoxEdit.MouseHover += new System.EventHandler(this.pictureBoxEdit_MouseHover);
            // 
            // toolTipNuke
            // 
            this.toolTipNuke.AutoPopDelay = 10000;
            this.toolTipNuke.InitialDelay = 500;
            this.toolTipNuke.IsBalloon = true;
            this.toolTipNuke.ReshowDelay = 100;
            this.toolTipNuke.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipNuke.ToolTipTitle = "Mensaje sonoro";
            // 
            // pictureBoxNuke
            // 
            this.pictureBoxNuke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNuke.Image = global::InterfazTerceraEdad.Properties.Resources.nuke_1;
            this.pictureBoxNuke.Location = new System.Drawing.Point(815, 131);
            this.pictureBoxNuke.Name = "pictureBoxNuke";
            this.pictureBoxNuke.Size = new System.Drawing.Size(155, 149);
            this.pictureBoxNuke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNuke.TabIndex = 8;
            this.pictureBoxNuke.TabStop = false;
            this.toolTipNuke.SetToolTip(this.pictureBoxNuke, "Produce un sonido audible sólo por los más jóvenes");
            this.pictureBoxNuke.MouseLeave += new System.EventHandler(this.pictureBoxNuke_MouseLeave);
            this.pictureBoxNuke.Click += new System.EventHandler(this.pictureBoxNuke_Click);
            this.pictureBoxNuke.MouseHover += new System.EventHandler(this.pictureBoxNuke_MouseHover);
            // 
            // labelDateWeekday
            // 
            this.labelDateWeekday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.labelDateWeekday.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateWeekday.ForeColor = System.Drawing.Color.White;
            this.labelDateWeekday.Location = new System.Drawing.Point(818, 625);
            this.labelDateWeekday.Name = "labelDateWeekday";
            this.labelDateWeekday.Size = new System.Drawing.Size(189, 60);
            this.labelDateWeekday.TabIndex = 9;
            this.labelDateWeekday.Text = "Miércoles";
            this.labelDateWeekday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipDateHour.SetToolTip(this.labelDateWeekday, "Día de la semana");
            // 
            // labelDateDay
            // 
            this.labelDateDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.labelDateDay.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDay.ForeColor = System.Drawing.Color.White;
            this.labelDateDay.Location = new System.Drawing.Point(829, 516);
            this.labelDateDay.Margin = new System.Windows.Forms.Padding(0);
            this.labelDateDay.Name = "labelDateDay";
            this.labelDateDay.Size = new System.Drawing.Size(172, 124);
            this.labelDateDay.TabIndex = 10;
            this.labelDateDay.Text = "29";
            this.labelDateDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipDateHour.SetToolTip(this.labelDateDay, "Día del mes");
            // 
            // labelDateHour
            // 
            this.labelDateHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.labelDateHour.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateHour.ForeColor = System.Drawing.Color.White;
            this.labelDateHour.Location = new System.Drawing.Point(817, 692);
            this.labelDateHour.Name = "labelDateHour";
            this.labelDateHour.Size = new System.Drawing.Size(189, 60);
            this.labelDateHour.TabIndex = 11;
            this.labelDateHour.Text = "12:00 PM";
            this.labelDateHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipDateHour.SetToolTip(this.labelDateHour, "Hora y minuto");
            // 
            // timerClock
            // 
            this.timerClock.Interval = 10000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // toolTipDateHour
            // 
            this.toolTipDateHour.IsBalloon = true;
            this.toolTipDateHour.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDateHour.ToolTipTitle = "Fecha y hora actual";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(1024, 768);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBack.TabIndex = 2;
            this.pictureBoxBack.TabStop = false;
            // 
            // timerNuke
            // 
            this.timerNuke.Interval = 250;
            this.timerNuke.Tick += new System.EventHandler(this.timerNuke_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.labelDateHour);
            this.Controls.Add(this.labelDateWeekday);
            this.Controls.Add(this.labelDateDay);
            this.Controls.Add(this.pictureBoxNuke);
            this.Controls.Add(this.pictureBoxOff);
            this.Controls.Add(this.pictureBoxMoney);
            this.Controls.Add(this.pictureBoxBrowser);
            this.Controls.Add(this.pictureBoxMail);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.pictureBoxBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.PictureBox pictureBoxMail;
        private System.Windows.Forms.PictureBox pictureBoxBrowser;
        private System.Windows.Forms.PictureBox pictureBoxMoney;
        private System.Windows.Forms.PictureBox pictureBoxOff;
        private System.Windows.Forms.PictureBox pictureBoxNuke;
        private System.Windows.Forms.ToolTip toolTipOff;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.ToolTip toolTipNuke;
        private System.Windows.Forms.Label labelDateWeekday;
        private System.Windows.Forms.Label labelDateDay;
        private System.Windows.Forms.Label labelDateHour;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ToolTip toolTipDateHour;
        private System.Windows.Forms.Timer timerNuke;
    }
}

