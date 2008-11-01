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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.actualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarAutomáticamenteAlIniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.zedGraphControlTemperature.Size = new System.Drawing.Size(735, 470);
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
            this.archivoToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(735, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDaToolStripMenuItem,
            this.toolStripMenuItem4,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // exportarDaToolStripMenuItem
            // 
            this.exportarDaToolStripMenuItem.Name = "exportarDaToolStripMenuItem";
            this.exportarDaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exportarDaToolStripMenuItem.Text = "&Exportar...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(123, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem1.Text = "&Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripComboBox1,
            this.actualizarToolStripMenuItem1});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actualizarToolStripMenuItem.Text = "&Sensor";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.conectarToolStripMenuItem.Text = "&Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click_1);
            // 
            // desconectarToolStripMenuItem1
            // 
            this.desconectarToolStripMenuItem1.Name = "desconectarToolStripMenuItem1";
            this.desconectarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.desconectarToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.desconectarToolStripMenuItem1.Text = "&Desconectar";
            this.desconectarToolStripMenuItem1.Click += new System.EventHandler(this.desconectarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 23);
            // 
            // actualizarToolStripMenuItem1
            // 
            this.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            this.actualizarToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualizarToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.actualizarToolStripMenuItem1.Text = "Actualizar puertos";
            this.actualizarToolStripMenuItem1.Click += new System.EventHandler(this.actualizarToolStripMenuItem1_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesDelProgramaToolStripMenuItem,
            this.conectarAutomáticamenteAlIniciarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // opcionesDelProgramaToolStripMenuItem
            // 
            this.opcionesDelProgramaToolStripMenuItem.Name = "opcionesDelProgramaToolStripMenuItem";
            this.opcionesDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.opcionesDelProgramaToolStripMenuItem.Text = "&Opciones...";
            // 
            // conectarAutomáticamenteAlIniciarToolStripMenuItem
            // 
            this.conectarAutomáticamenteAlIniciarToolStripMenuItem.Checked = true;
            this.conectarAutomáticamenteAlIniciarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.conectarAutomáticamenteAlIniciarToolStripMenuItem.Name = "conectarAutomáticamenteAlIniciarToolStripMenuItem";
            this.conectarAutomáticamenteAlIniciarToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.conectarAutomáticamenteAlIniciarToolStripMenuItem.Text = "Conectar automáticamente al iniciar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelProgramaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // acercaDelProgramaToolStripMenuItem
            // 
            this.acercaDelProgramaToolStripMenuItem.Name = "acercaDelProgramaToolStripMenuItem";
            this.acercaDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.acercaDelProgramaToolStripMenuItem.Text = "Acerca del programa";
            this.acercaDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelProgramaToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 494);
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
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exportarDaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarAutomáticamenteAlIniciarToolStripMenuItem;
    }
}

