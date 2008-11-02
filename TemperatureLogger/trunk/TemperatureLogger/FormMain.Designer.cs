namespace TemperatureLogger
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
            this.zedGraphControlTemperature = new ZedGraph.ZedGraphControl();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxPort = new System.Windows.Forms.ToolStripComboBox();
            this.updatePortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupAutoConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControlTemperature
            // 
            this.zedGraphControlTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControlTemperature.IsAntiAlias = true;
            this.zedGraphControlTemperature.IsAutoScrollRange = true;
            this.zedGraphControlTemperature.IsShowPointValues = true;
            this.zedGraphControlTemperature.Location = new System.Drawing.Point(0, 24);
            this.zedGraphControlTemperature.Name = "zedGraphControlTemperature";
            this.zedGraphControlTemperature.PointDateFormat = "G";
            this.zedGraphControlTemperature.PointValueFormat = "f2";
            this.zedGraphControlTemperature.ScrollGrace = 0;
            this.zedGraphControlTemperature.ScrollMaxX = 0;
            this.zedGraphControlTemperature.ScrollMaxY = 0;
            this.zedGraphControlTemperature.ScrollMaxY2 = 0;
            this.zedGraphControlTemperature.ScrollMinX = 0;
            this.zedGraphControlTemperature.ScrollMinY = 0;
            this.zedGraphControlTemperature.ScrollMinY2 = 0;
            this.zedGraphControlTemperature.Size = new System.Drawing.Size(650, 415);
            this.zedGraphControlTemperature.TabIndex = 0;
            this.zedGraphControlTemperature.ZoomButtons2 = System.Windows.Forms.MouseButtons.Right;
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.PortName = "COM32";
            this.serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduino_DataReceived);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sensorToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(650, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripMenuItem4,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Archivo";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "&Exportar...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem1.Text = "&Salir";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripComboBoxPort,
            this.updatePortsToolStripMenuItem});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sensorToolStripMenuItem.Text = "&Sensor";
            this.sensorToolStripMenuItem.Click += new System.EventHandler(this.uptadeToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.connectToolStripMenuItem.Text = "&Conectar";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click_1);
            // 
            // disconnectToolStripMenuItem1
            // 
            this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
            this.disconnectToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.disconnectToolStripMenuItem1.Text = "&Desconectar";
            this.disconnectToolStripMenuItem1.Click += new System.EventHandler(this.desconectarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // toolStripComboBoxPort
            // 
            this.toolStripComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxPort.Name = "toolStripComboBoxPort";
            this.toolStripComboBoxPort.Size = new System.Drawing.Size(75, 23);
            // 
            // updatePortsToolStripMenuItem
            // 
            this.updatePortsToolStripMenuItem.Name = "updatePortsToolStripMenuItem";
            this.updatePortsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.updatePortsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.updatePortsToolStripMenuItem.Text = "Actualizar puertos";
            this.updatePortsToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothGraphToolStripMenuItem,
            this.startupAutoConnectToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            // 
            // smoothGraphToolStripMenuItem
            // 
            this.smoothGraphToolStripMenuItem.Checked = true;
            this.smoothGraphToolStripMenuItem.CheckOnClick = true;
            this.smoothGraphToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smoothGraphToolStripMenuItem.Name = "smoothGraphToolStripMenuItem";
            this.smoothGraphToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.smoothGraphToolStripMenuItem.Text = "&Suavizar la curva graficada";
            this.smoothGraphToolStripMenuItem.Click += new System.EventHandler(this.smoothGraphToolStripMenuItem_Click);
            // 
            // startupAutoConnectToolStripMenuItem
            // 
            this.startupAutoConnectToolStripMenuItem.Checked = true;
            this.startupAutoConnectToolStripMenuItem.CheckOnClick = true;
            this.startupAutoConnectToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startupAutoConnectToolStripMenuItem.Name = "startupAutoConnectToolStripMenuItem";
            this.startupAutoConnectToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.startupAutoConnectToolStripMenuItem.Text = "Conectar automáticamente al iniciar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelProgramaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "A&yuda";
            // 
            // acercaDelProgramaToolStripMenuItem
            // 
            this.acercaDelProgramaToolStripMenuItem.Name = "acercaDelProgramaToolStripMenuItem";
            this.acercaDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.acercaDelProgramaToolStripMenuItem.Text = "Acerca del programa";
            this.acercaDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 439);
            this.Controls.Add(this.zedGraphControlTemperature);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControlTemperature;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxPort;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupAutoConnectToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
    }
}

