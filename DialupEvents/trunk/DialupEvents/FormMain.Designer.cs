namespace DialupEvents
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listDialupEvents = new System.Windows.Forms.ListView();
            this.columnHeaderMsg = new System.Windows.Forms.ColumnHeader(resources.GetString("listDialupEvents.Columns"));
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTime = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCount = new System.Windows.Forms.ColumnHeader();
            this.contextMenuEvents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarLista = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.calcularCostoDeConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.appIcons = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePickerIni = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.grupoIntervalo = new System.Windows.Forms.GroupBox();
            this.intervaloHasta = new System.Windows.Forms.Label();
            this.intervaloDesde = new System.Windows.Forms.Label();
            this.buttonCalculateCost = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.buttonExport = new System.Windows.Forms.Button();
            this.saveLogFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuEvents.SuspendLayout();
            this.grupoIntervalo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AccessibleDescription = null;
            this.buttonUpdate.AccessibleName = null;
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.BackgroundImage = null;
            this.buttonUpdate.Font = null;
            this.buttonUpdate.Name = "buttonUpdate";
            this.toolTipInfo.SetToolTip(this.buttonUpdate, resources.GetString("buttonUpdate.ToolTip"));
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listDialupEvents
            // 
            this.listDialupEvents.AccessibleDescription = null;
            this.listDialupEvents.AccessibleName = null;
            resources.ApplyResources(this.listDialupEvents, "listDialupEvents");
            this.listDialupEvents.AllowColumnReorder = true;
            this.listDialupEvents.BackgroundImage = null;
            this.listDialupEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMsg,
            this.columnHeaderDate,
            this.columnHeaderTime,
            this.columnHeaderCount});
            this.listDialupEvents.ContextMenuStrip = this.contextMenuEvents;
            this.listDialupEvents.Font = null;
            this.listDialupEvents.FullRowSelect = true;
            this.listDialupEvents.Name = "listDialupEvents";
            this.listDialupEvents.SmallImageList = this.appIcons;
            this.toolTipInfo.SetToolTip(this.listDialupEvents, resources.GetString("listDialupEvents.ToolTip"));
            this.listDialupEvents.UseCompatibleStateImageBehavior = false;
            this.listDialupEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMsg
            // 
            resources.ApplyResources(this.columnHeaderMsg, "columnHeaderMsg");
            // 
            // columnHeaderDate
            // 
            resources.ApplyResources(this.columnHeaderDate, "columnHeaderDate");
            // 
            // columnHeaderTime
            // 
            resources.ApplyResources(this.columnHeaderTime, "columnHeaderTime");
            // 
            // columnHeaderCount
            // 
            resources.ApplyResources(this.columnHeaderCount, "columnHeaderCount");
            // 
            // contextMenuEvents
            // 
            this.contextMenuEvents.AccessibleDescription = null;
            this.contextMenuEvents.AccessibleName = null;
            resources.ApplyResources(this.contextMenuEvents, "contextMenuEvents");
            this.contextMenuEvents.BackgroundImage = null;
            this.contextMenuEvents.Font = null;
            this.contextMenuEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarLista,
            this.toolStripMenuItem1,
            this.calcularCostoDeConexion,
            this.exportarToolStripMenuItem});
            this.contextMenuEvents.Name = "contextMenuEvents";
            this.toolTipInfo.SetToolTip(this.contextMenuEvents, resources.GetString("contextMenuEvents.ToolTip"));
            this.contextMenuEvents.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuEvents_Opening);
            // 
            // actualizarLista
            // 
            this.actualizarLista.AccessibleDescription = null;
            this.actualizarLista.AccessibleName = null;
            resources.ApplyResources(this.actualizarLista, "actualizarLista");
            this.actualizarLista.BackgroundImage = null;
            this.actualizarLista.Name = "actualizarLista";
            this.actualizarLista.ShortcutKeyDisplayString = null;
            this.actualizarLista.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleDescription = null;
            this.toolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // calcularCostoDeConexion
            // 
            this.calcularCostoDeConexion.AccessibleDescription = null;
            this.calcularCostoDeConexion.AccessibleName = null;
            resources.ApplyResources(this.calcularCostoDeConexion, "calcularCostoDeConexion");
            this.calcularCostoDeConexion.BackgroundImage = null;
            this.calcularCostoDeConexion.Name = "calcularCostoDeConexion";
            this.calcularCostoDeConexion.ShortcutKeyDisplayString = null;
            this.calcularCostoDeConexion.Click += new System.EventHandler(this.calcularCostoDeConexiónToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.AccessibleDescription = null;
            this.exportarToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exportarToolStripMenuItem, "exportarToolStripMenuItem");
            this.exportarToolStripMenuItem.BackgroundImage = null;
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllEvents,
            this.exportSelection});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // exportAllEvents
            // 
            this.exportAllEvents.AccessibleDescription = null;
            this.exportAllEvents.AccessibleName = null;
            resources.ApplyResources(this.exportAllEvents, "exportAllEvents");
            this.exportAllEvents.BackgroundImage = null;
            this.exportAllEvents.Name = "exportAllEvents";
            this.exportAllEvents.ShortcutKeyDisplayString = null;
            this.exportAllEvents.Click += new System.EventHandler(this.exportAllEvents_Click);
            // 
            // exportSelection
            // 
            this.exportSelection.AccessibleDescription = null;
            this.exportSelection.AccessibleName = null;
            resources.ApplyResources(this.exportSelection, "exportSelection");
            this.exportSelection.BackgroundImage = null;
            this.exportSelection.Name = "exportSelection";
            this.exportSelection.ShortcutKeyDisplayString = null;
            this.exportSelection.Click += new System.EventHandler(this.exportSelection_Click);
            // 
            // appIcons
            // 
            this.appIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("appIcons.ImageStream")));
            this.appIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.appIcons.Images.SetKeyName(0, "dial.ico");
            this.appIcons.Images.SetKeyName(1, "dial_on.ico");
            this.appIcons.Images.SetKeyName(2, "dial_off.ico");
            // 
            // dateTimePickerIni
            // 
            this.dateTimePickerIni.AccessibleDescription = null;
            this.dateTimePickerIni.AccessibleName = null;
            resources.ApplyResources(this.dateTimePickerIni, "dateTimePickerIni");
            this.dateTimePickerIni.BackgroundImage = null;
            this.dateTimePickerIni.CalendarFont = null;
            this.dateTimePickerIni.Font = null;
            this.dateTimePickerIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIni.MaxDate = new System.DateTime(2036, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIni.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerIni.Name = "dateTimePickerIni";
            this.toolTipInfo.SetToolTip(this.dateTimePickerIni, resources.GetString("dateTimePickerIni.ToolTip"));
            this.dateTimePickerIni.ValueChanged += new System.EventHandler(this.dateTimePickerIni_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.AccessibleDescription = null;
            this.dateTimePickerEnd.AccessibleName = null;
            resources.ApplyResources(this.dateTimePickerEnd, "dateTimePickerEnd");
            this.dateTimePickerEnd.BackgroundImage = null;
            this.dateTimePickerEnd.CalendarFont = null;
            this.dateTimePickerEnd.Font = null;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.MaxDate = new System.DateTime(2036, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.toolTipInfo.SetToolTip(this.dateTimePickerEnd, resources.GetString("dateTimePickerEnd.ToolTip"));
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // grupoIntervalo
            // 
            this.grupoIntervalo.AccessibleDescription = null;
            this.grupoIntervalo.AccessibleName = null;
            resources.ApplyResources(this.grupoIntervalo, "grupoIntervalo");
            this.grupoIntervalo.BackgroundImage = null;
            this.grupoIntervalo.Controls.Add(this.intervaloHasta);
            this.grupoIntervalo.Controls.Add(this.intervaloDesde);
            this.grupoIntervalo.Controls.Add(this.dateTimePickerIni);
            this.grupoIntervalo.Controls.Add(this.dateTimePickerEnd);
            this.grupoIntervalo.Font = null;
            this.grupoIntervalo.Name = "grupoIntervalo";
            this.grupoIntervalo.TabStop = false;
            this.toolTipInfo.SetToolTip(this.grupoIntervalo, resources.GetString("grupoIntervalo.ToolTip"));
            // 
            // intervaloHasta
            // 
            this.intervaloHasta.AccessibleDescription = null;
            this.intervaloHasta.AccessibleName = null;
            resources.ApplyResources(this.intervaloHasta, "intervaloHasta");
            this.intervaloHasta.Font = null;
            this.intervaloHasta.Name = "intervaloHasta";
            this.toolTipInfo.SetToolTip(this.intervaloHasta, resources.GetString("intervaloHasta.ToolTip"));
            // 
            // intervaloDesde
            // 
            this.intervaloDesde.AccessibleDescription = null;
            this.intervaloDesde.AccessibleName = null;
            resources.ApplyResources(this.intervaloDesde, "intervaloDesde");
            this.intervaloDesde.Font = null;
            this.intervaloDesde.Name = "intervaloDesde";
            this.toolTipInfo.SetToolTip(this.intervaloDesde, resources.GetString("intervaloDesde.ToolTip"));
            // 
            // buttonCalculateCost
            // 
            this.buttonCalculateCost.AccessibleDescription = null;
            this.buttonCalculateCost.AccessibleName = null;
            resources.ApplyResources(this.buttonCalculateCost, "buttonCalculateCost");
            this.buttonCalculateCost.BackgroundImage = null;
            this.buttonCalculateCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalculateCost.Name = "buttonCalculateCost";
            this.toolTipInfo.SetToolTip(this.buttonCalculateCost, resources.GetString("buttonCalculateCost.ToolTip"));
            this.buttonCalculateCost.UseVisualStyleBackColor = true;
            this.buttonCalculateCost.Click += new System.EventHandler(this.buttonCalculateCost_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.AccessibleDescription = null;
            this.buttonExport.AccessibleName = null;
            resources.ApplyResources(this.buttonExport, "buttonExport");
            this.buttonExport.BackgroundImage = null;
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExport.Name = "buttonExport";
            this.toolTipInfo.SetToolTip(this.buttonExport, resources.GetString("buttonExport.ToolTip"));
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // saveLogFileDialog
            // 
            resources.ApplyResources(this.saveLogFileDialog, "saveLogFileDialog");
            // 
            // FormMain
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.grupoIntervalo);
            this.Controls.Add(this.listDialupEvents);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCalculateCost);
            this.Font = null;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.toolTipInfo.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuEvents.ResumeLayout(false);
            this.grupoIntervalo.ResumeLayout(false);
            this.grupoIntervalo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ListView listDialupEvents;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderMsg;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ImageList appIcons;
        private System.Windows.Forms.ColumnHeader columnHeaderCount;
        private System.Windows.Forms.DateTimePicker dateTimePickerIni;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.GroupBox grupoIntervalo;
        private System.Windows.Forms.Label intervaloHasta;
        private System.Windows.Forms.Label intervaloDesde;
        private System.Windows.Forms.ContextMenuStrip contextMenuEvents;
        private System.Windows.Forms.ToolStripMenuItem actualizarLista;
        private System.Windows.Forms.ToolStripMenuItem calcularCostoDeConexion;
        private System.Windows.Forms.Button buttonCalculateCost;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllEvents;
        private System.Windows.Forms.SaveFileDialog saveLogFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exportSelection;
        private System.Windows.Forms.Button buttonExport;
    }
}

