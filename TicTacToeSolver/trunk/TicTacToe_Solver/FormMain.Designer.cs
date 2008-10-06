namespace TicTacToe
{
    /// <summary>
    /// Formulario principal
    /// </summary>
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxSolutionBrowser = new System.Windows.Forms.GroupBox();
            this.textBoxParent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTurn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSubIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBoardDeeper = new System.Windows.Forms.Button();
            this.buttonBoardNext = new System.Windows.Forms.Button();
            this.buttonBoardPrevious = new System.Windows.Forms.Button();
            this.buttonBoard8 = new System.Windows.Forms.Button();
            this.buttonBoard7 = new System.Windows.Forms.Button();
            this.buttonBoard5 = new System.Windows.Forms.Button();
            this.buttonBoard4 = new System.Windows.Forms.Button();
            this.buttonBoard6 = new System.Windows.Forms.Button();
            this.buttonBoard3 = new System.Windows.Forms.Button();
            this.buttonBoard2 = new System.Windows.Forms.Button();
            this.buttonBoard1 = new System.Windows.Forms.Button();
            this.buttonBoard0 = new System.Windows.Forms.Button();
            this.buttonBoardParent = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMinMax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMinMaxDetails = new System.Windows.Forms.GroupBox();
            this.textBoxMinMaxTurn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMinMaxDepth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMinMaxWeight = new System.Windows.Forms.TextBox();
            this.textBoxMinMaxParent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxMinMaxDetails = new System.Windows.Forms.CheckBox();
            this.checkBoxMinMaxDelay = new System.Windows.Forms.CheckBox();
            this.buttonMinMaxReset = new System.Windows.Forms.Button();
            this.buttonMinMaxComputer = new System.Windows.Forms.Button();
            this.buttonMinMax9 = new System.Windows.Forms.Button();
            this.buttonMinMax8 = new System.Windows.Forms.Button();
            this.buttonMinMax7 = new System.Windows.Forms.Button();
            this.buttonMinMax6 = new System.Windows.Forms.Button();
            this.buttonMinMax5 = new System.Windows.Forms.Button();
            this.buttonMinMax4 = new System.Windows.Forms.Button();
            this.buttonMinMax3 = new System.Windows.Forms.Button();
            this.buttonMinMax2 = new System.Windows.Forms.Button();
            this.buttonMinMax1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelHeu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxHeuDetails = new System.Windows.Forms.GroupBox();
            this.textBoxHeuTurn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxHeuDepth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxHeuWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeuParent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxHeuDetails = new System.Windows.Forms.CheckBox();
            this.checkBoxHeuDelay = new System.Windows.Forms.CheckBox();
            this.buttonHeuReset = new System.Windows.Forms.Button();
            this.buttonHeuComputer = new System.Windows.Forms.Button();
            this.buttonHeu9 = new System.Windows.Forms.Button();
            this.buttonHeu8 = new System.Windows.Forms.Button();
            this.buttonHeu7 = new System.Windows.Forms.Button();
            this.buttonHeu6 = new System.Windows.Forms.Button();
            this.buttonHeu5 = new System.Windows.Forms.Button();
            this.buttonHeu4 = new System.Windows.Forms.Button();
            this.buttonHeu3 = new System.Windows.Forms.Button();
            this.buttonHeu2 = new System.Windows.Forms.Button();
            this.buttonHeu1 = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGC = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveTicTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateUtilityFromBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.initialPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1StartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2StartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.minmaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAtcenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSolutionBrowser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMinMaxDetails.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxHeuDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelStatus);
            this.tabPage1.Controls.Add(this.groupBoxSolutionBrowser);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // groupBoxSolutionBrowser
            // 
            this.groupBoxSolutionBrowser.Controls.Add(this.textBoxParent);
            this.groupBoxSolutionBrowser.Controls.Add(this.label5);
            this.groupBoxSolutionBrowser.Controls.Add(this.textBoxTurn);
            this.groupBoxSolutionBrowser.Controls.Add(this.label4);
            this.groupBoxSolutionBrowser.Controls.Add(this.textBoxSubIndex);
            this.groupBoxSolutionBrowser.Controls.Add(this.label3);
            this.groupBoxSolutionBrowser.Controls.Add(this.textBoxWeight);
            this.groupBoxSolutionBrowser.Controls.Add(this.textBoxDepth);
            this.groupBoxSolutionBrowser.Controls.Add(this.label2);
            this.groupBoxSolutionBrowser.Controls.Add(this.label1);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoardDeeper);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoardNext);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoardPrevious);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard8);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard7);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard5);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard4);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard6);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard3);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard2);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard1);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoard0);
            this.groupBoxSolutionBrowser.Controls.Add(this.buttonBoardParent);
            resources.ApplyResources(this.groupBoxSolutionBrowser, "groupBoxSolutionBrowser");
            this.groupBoxSolutionBrowser.Name = "groupBoxSolutionBrowser";
            this.groupBoxSolutionBrowser.TabStop = false;
            // 
            // textBoxParent
            // 
            resources.ApplyResources(this.textBoxParent, "textBoxParent");
            this.textBoxParent.Name = "textBoxParent";
            this.textBoxParent.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxTurn
            // 
            resources.ApplyResources(this.textBoxTurn, "textBoxTurn");
            this.textBoxTurn.Name = "textBoxTurn";
            this.textBoxTurn.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxSubIndex
            // 
            resources.ApplyResources(this.textBoxSubIndex, "textBoxSubIndex");
            this.textBoxSubIndex.Name = "textBoxSubIndex";
            this.textBoxSubIndex.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxWeight
            // 
            resources.ApplyResources(this.textBoxWeight, "textBoxWeight");
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            // 
            // textBoxDepth
            // 
            resources.ApplyResources(this.textBoxDepth, "textBoxDepth");
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonBoardDeeper
            // 
            resources.ApplyResources(this.buttonBoardDeeper, "buttonBoardDeeper");
            this.buttonBoardDeeper.Name = "buttonBoardDeeper";
            this.buttonBoardDeeper.UseVisualStyleBackColor = true;
            this.buttonBoardDeeper.Click += new System.EventHandler(this.buttonBoardDeeper_Click);
            // 
            // buttonBoardNext
            // 
            resources.ApplyResources(this.buttonBoardNext, "buttonBoardNext");
            this.buttonBoardNext.Name = "buttonBoardNext";
            this.buttonBoardNext.UseVisualStyleBackColor = true;
            this.buttonBoardNext.Click += new System.EventHandler(this.buttonBoardNext_Click);
            // 
            // buttonBoardPrevious
            // 
            resources.ApplyResources(this.buttonBoardPrevious, "buttonBoardPrevious");
            this.buttonBoardPrevious.Name = "buttonBoardPrevious";
            this.buttonBoardPrevious.UseVisualStyleBackColor = true;
            this.buttonBoardPrevious.Click += new System.EventHandler(this.buttonBoardPrevious_Click);
            // 
            // buttonBoard8
            // 
            this.buttonBoard8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard8, "buttonBoard8");
            this.buttonBoard8.Name = "buttonBoard8";
            this.buttonBoard8.TabStop = false;
            this.buttonBoard8.UseCompatibleTextRendering = true;
            this.buttonBoard8.UseVisualStyleBackColor = true;
            // 
            // buttonBoard7
            // 
            this.buttonBoard7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard7, "buttonBoard7");
            this.buttonBoard7.Name = "buttonBoard7";
            this.buttonBoard7.TabStop = false;
            this.buttonBoard7.UseCompatibleTextRendering = true;
            this.buttonBoard7.UseVisualStyleBackColor = true;
            // 
            // buttonBoard5
            // 
            this.buttonBoard5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard5, "buttonBoard5");
            this.buttonBoard5.Name = "buttonBoard5";
            this.buttonBoard5.TabStop = false;
            this.buttonBoard5.UseCompatibleTextRendering = true;
            this.buttonBoard5.UseVisualStyleBackColor = true;
            // 
            // buttonBoard4
            // 
            this.buttonBoard4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard4, "buttonBoard4");
            this.buttonBoard4.Name = "buttonBoard4";
            this.buttonBoard4.TabStop = false;
            this.buttonBoard4.UseCompatibleTextRendering = true;
            this.buttonBoard4.UseVisualStyleBackColor = true;
            // 
            // buttonBoard6
            // 
            this.buttonBoard6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard6, "buttonBoard6");
            this.buttonBoard6.Name = "buttonBoard6";
            this.buttonBoard6.TabStop = false;
            this.buttonBoard6.UseCompatibleTextRendering = true;
            this.buttonBoard6.UseVisualStyleBackColor = true;
            // 
            // buttonBoard3
            // 
            this.buttonBoard3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard3, "buttonBoard3");
            this.buttonBoard3.Name = "buttonBoard3";
            this.buttonBoard3.TabStop = false;
            this.buttonBoard3.UseCompatibleTextRendering = true;
            this.buttonBoard3.UseVisualStyleBackColor = true;
            // 
            // buttonBoard2
            // 
            this.buttonBoard2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard2, "buttonBoard2");
            this.buttonBoard2.Name = "buttonBoard2";
            this.buttonBoard2.TabStop = false;
            this.buttonBoard2.UseCompatibleTextRendering = true;
            this.buttonBoard2.UseVisualStyleBackColor = true;
            // 
            // buttonBoard1
            // 
            this.buttonBoard1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard1, "buttonBoard1");
            this.buttonBoard1.Name = "buttonBoard1";
            this.buttonBoard1.TabStop = false;
            this.buttonBoard1.UseCompatibleTextRendering = true;
            this.buttonBoard1.UseVisualStyleBackColor = true;
            // 
            // buttonBoard0
            // 
            this.buttonBoard0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBoard0, "buttonBoard0");
            this.buttonBoard0.Name = "buttonBoard0";
            this.buttonBoard0.TabStop = false;
            this.buttonBoard0.UseCompatibleTextRendering = true;
            this.buttonBoard0.UseVisualStyleBackColor = true;
            // 
            // buttonBoardParent
            // 
            resources.ApplyResources(this.buttonBoardParent, "buttonBoardParent");
            this.buttonBoardParent.Name = "buttonBoardParent";
            this.buttonBoardParent.UseVisualStyleBackColor = true;
            this.buttonBoardParent.Click += new System.EventHandler(this.buttonBoardParent_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelMinMax);
            this.tabPage2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelMinMax
            // 
            resources.ApplyResources(this.labelMinMax, "labelMinMax");
            this.labelMinMax.Name = "labelMinMax";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxMinMaxDetails);
            this.groupBox1.Controls.Add(this.checkBoxMinMaxDetails);
            this.groupBox1.Controls.Add(this.checkBoxMinMaxDelay);
            this.groupBox1.Controls.Add(this.buttonMinMaxReset);
            this.groupBox1.Controls.Add(this.buttonMinMaxComputer);
            this.groupBox1.Controls.Add(this.buttonMinMax9);
            this.groupBox1.Controls.Add(this.buttonMinMax8);
            this.groupBox1.Controls.Add(this.buttonMinMax7);
            this.groupBox1.Controls.Add(this.buttonMinMax6);
            this.groupBox1.Controls.Add(this.buttonMinMax5);
            this.groupBox1.Controls.Add(this.buttonMinMax4);
            this.groupBox1.Controls.Add(this.buttonMinMax3);
            this.groupBox1.Controls.Add(this.buttonMinMax2);
            this.groupBox1.Controls.Add(this.buttonMinMax1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBoxMinMaxDetails
            // 
            this.groupBoxMinMaxDetails.Controls.Add(this.textBoxMinMaxTurn);
            this.groupBoxMinMaxDetails.Controls.Add(this.label7);
            this.groupBoxMinMaxDetails.Controls.Add(this.textBoxMinMaxDepth);
            this.groupBoxMinMaxDetails.Controls.Add(this.label8);
            this.groupBoxMinMaxDetails.Controls.Add(this.textBoxMinMaxWeight);
            this.groupBoxMinMaxDetails.Controls.Add(this.textBoxMinMaxParent);
            this.groupBoxMinMaxDetails.Controls.Add(this.label9);
            this.groupBoxMinMaxDetails.Controls.Add(this.label10);
            resources.ApplyResources(this.groupBoxMinMaxDetails, "groupBoxMinMaxDetails");
            this.groupBoxMinMaxDetails.Name = "groupBoxMinMaxDetails";
            this.groupBoxMinMaxDetails.TabStop = false;
            // 
            // textBoxMinMaxTurn
            // 
            resources.ApplyResources(this.textBoxMinMaxTurn, "textBoxMinMaxTurn");
            this.textBoxMinMaxTurn.Name = "textBoxMinMaxTurn";
            this.textBoxMinMaxTurn.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxMinMaxDepth
            // 
            resources.ApplyResources(this.textBoxMinMaxDepth, "textBoxMinMaxDepth");
            this.textBoxMinMaxDepth.Name = "textBoxMinMaxDepth";
            this.textBoxMinMaxDepth.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBoxMinMaxWeight
            // 
            resources.ApplyResources(this.textBoxMinMaxWeight, "textBoxMinMaxWeight");
            this.textBoxMinMaxWeight.Name = "textBoxMinMaxWeight";
            this.textBoxMinMaxWeight.ReadOnly = true;
            // 
            // textBoxMinMaxParent
            // 
            resources.ApplyResources(this.textBoxMinMaxParent, "textBoxMinMaxParent");
            this.textBoxMinMaxParent.Name = "textBoxMinMaxParent";
            this.textBoxMinMaxParent.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // checkBoxMinMaxDetails
            // 
            resources.ApplyResources(this.checkBoxMinMaxDetails, "checkBoxMinMaxDetails");
            this.checkBoxMinMaxDetails.Name = "checkBoxMinMaxDetails";
            this.checkBoxMinMaxDetails.UseVisualStyleBackColor = true;
            this.checkBoxMinMaxDetails.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxMinMaxDelay
            // 
            resources.ApplyResources(this.checkBoxMinMaxDelay, "checkBoxMinMaxDelay");
            this.checkBoxMinMaxDelay.Name = "checkBoxMinMaxDelay";
            this.checkBoxMinMaxDelay.UseVisualStyleBackColor = true;
            // 
            // buttonMinMaxReset
            // 
            resources.ApplyResources(this.buttonMinMaxReset, "buttonMinMaxReset");
            this.buttonMinMaxReset.Name = "buttonMinMaxReset";
            this.buttonMinMaxReset.UseVisualStyleBackColor = true;
            this.buttonMinMaxReset.Click += new System.EventHandler(this.buttonMinMaxReset_Click);
            // 
            // buttonMinMaxComputer
            // 
            resources.ApplyResources(this.buttonMinMaxComputer, "buttonMinMaxComputer");
            this.buttonMinMaxComputer.Name = "buttonMinMaxComputer";
            this.buttonMinMaxComputer.UseVisualStyleBackColor = true;
            this.buttonMinMaxComputer.Click += new System.EventHandler(this.buttonMinMaxComputer_Click);
            // 
            // buttonMinMax9
            // 
            this.buttonMinMax9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax9, "buttonMinMax9");
            this.buttonMinMax9.Name = "buttonMinMax9";
            this.buttonMinMax9.Tag = "9";
            this.buttonMinMax9.UseVisualStyleBackColor = true;
            this.buttonMinMax9.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax8
            // 
            this.buttonMinMax8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax8, "buttonMinMax8");
            this.buttonMinMax8.Name = "buttonMinMax8";
            this.buttonMinMax8.Tag = "8";
            this.buttonMinMax8.UseVisualStyleBackColor = true;
            this.buttonMinMax8.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax7
            // 
            this.buttonMinMax7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax7, "buttonMinMax7");
            this.buttonMinMax7.Name = "buttonMinMax7";
            this.buttonMinMax7.Tag = "7";
            this.buttonMinMax7.UseVisualStyleBackColor = true;
            this.buttonMinMax7.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax6
            // 
            this.buttonMinMax6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax6, "buttonMinMax6");
            this.buttonMinMax6.Name = "buttonMinMax6";
            this.buttonMinMax6.Tag = "6";
            this.buttonMinMax6.UseVisualStyleBackColor = true;
            this.buttonMinMax6.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax5
            // 
            this.buttonMinMax5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax5, "buttonMinMax5");
            this.buttonMinMax5.Name = "buttonMinMax5";
            this.buttonMinMax5.Tag = "5";
            this.buttonMinMax5.UseVisualStyleBackColor = true;
            this.buttonMinMax5.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax4
            // 
            this.buttonMinMax4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax4, "buttonMinMax4");
            this.buttonMinMax4.Name = "buttonMinMax4";
            this.buttonMinMax4.Tag = "4";
            this.buttonMinMax4.UseVisualStyleBackColor = true;
            this.buttonMinMax4.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax3
            // 
            this.buttonMinMax3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax3, "buttonMinMax3");
            this.buttonMinMax3.Name = "buttonMinMax3";
            this.buttonMinMax3.Tag = "3";
            this.buttonMinMax3.UseVisualStyleBackColor = true;
            this.buttonMinMax3.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax2
            // 
            this.buttonMinMax2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax2, "buttonMinMax2");
            this.buttonMinMax2.Name = "buttonMinMax2";
            this.buttonMinMax2.Tag = "2";
            this.buttonMinMax2.UseVisualStyleBackColor = true;
            this.buttonMinMax2.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMinMax1
            // 
            this.buttonMinMax1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinMax1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonMinMax1, "buttonMinMax1");
            this.buttonMinMax1.Name = "buttonMinMax1";
            this.buttonMinMax1.Tag = "1";
            this.buttonMinMax1.UseVisualStyleBackColor = true;
            this.buttonMinMax1.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelHeu);
            this.tabPage3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelHeu
            // 
            resources.ApplyResources(this.labelHeu, "labelHeu");
            this.labelHeu.Name = "labelHeu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxHeuDetails);
            this.groupBox2.Controls.Add(this.checkBoxHeuDetails);
            this.groupBox2.Controls.Add(this.checkBoxHeuDelay);
            this.groupBox2.Controls.Add(this.buttonHeuReset);
            this.groupBox2.Controls.Add(this.buttonHeuComputer);
            this.groupBox2.Controls.Add(this.buttonHeu9);
            this.groupBox2.Controls.Add(this.buttonHeu8);
            this.groupBox2.Controls.Add(this.buttonHeu7);
            this.groupBox2.Controls.Add(this.buttonHeu6);
            this.groupBox2.Controls.Add(this.buttonHeu5);
            this.groupBox2.Controls.Add(this.buttonHeu4);
            this.groupBox2.Controls.Add(this.buttonHeu3);
            this.groupBox2.Controls.Add(this.buttonHeu2);
            this.groupBox2.Controls.Add(this.buttonHeu1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBoxHeuDetails
            // 
            this.groupBoxHeuDetails.Controls.Add(this.textBoxHeuTurn);
            this.groupBoxHeuDetails.Controls.Add(this.label11);
            this.groupBoxHeuDetails.Controls.Add(this.textBoxHeuDepth);
            this.groupBoxHeuDetails.Controls.Add(this.label12);
            this.groupBoxHeuDetails.Controls.Add(this.textBoxHeuWeight);
            this.groupBoxHeuDetails.Controls.Add(this.textBoxHeuParent);
            this.groupBoxHeuDetails.Controls.Add(this.label13);
            this.groupBoxHeuDetails.Controls.Add(this.label14);
            resources.ApplyResources(this.groupBoxHeuDetails, "groupBoxHeuDetails");
            this.groupBoxHeuDetails.Name = "groupBoxHeuDetails";
            this.groupBoxHeuDetails.TabStop = false;
            // 
            // textBoxHeuTurn
            // 
            resources.ApplyResources(this.textBoxHeuTurn, "textBoxHeuTurn");
            this.textBoxHeuTurn.Name = "textBoxHeuTurn";
            this.textBoxHeuTurn.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxHeuDepth
            // 
            resources.ApplyResources(this.textBoxHeuDepth, "textBoxHeuDepth");
            this.textBoxHeuDepth.Name = "textBoxHeuDepth";
            this.textBoxHeuDepth.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // textBoxHeuWeight
            // 
            resources.ApplyResources(this.textBoxHeuWeight, "textBoxHeuWeight");
            this.textBoxHeuWeight.Name = "textBoxHeuWeight";
            this.textBoxHeuWeight.ReadOnly = true;
            // 
            // textBoxHeuParent
            // 
            resources.ApplyResources(this.textBoxHeuParent, "textBoxHeuParent");
            this.textBoxHeuParent.Name = "textBoxHeuParent";
            this.textBoxHeuParent.ReadOnly = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // checkBoxHeuDetails
            // 
            resources.ApplyResources(this.checkBoxHeuDetails, "checkBoxHeuDetails");
            this.checkBoxHeuDetails.Name = "checkBoxHeuDetails";
            this.checkBoxHeuDetails.UseVisualStyleBackColor = true;
            this.checkBoxHeuDetails.CheckedChanged += new System.EventHandler(this.checkBoxHeuDetails_CheckedChanged);
            // 
            // checkBoxHeuDelay
            // 
            resources.ApplyResources(this.checkBoxHeuDelay, "checkBoxHeuDelay");
            this.checkBoxHeuDelay.Name = "checkBoxHeuDelay";
            this.checkBoxHeuDelay.UseVisualStyleBackColor = true;
            // 
            // buttonHeuReset
            // 
            resources.ApplyResources(this.buttonHeuReset, "buttonHeuReset");
            this.buttonHeuReset.Name = "buttonHeuReset";
            this.buttonHeuReset.UseVisualStyleBackColor = true;
            this.buttonHeuReset.Click += new System.EventHandler(this.buttonHeuReset_Click);
            // 
            // buttonHeuComputer
            // 
            resources.ApplyResources(this.buttonHeuComputer, "buttonHeuComputer");
            this.buttonHeuComputer.Name = "buttonHeuComputer";
            this.buttonHeuComputer.UseVisualStyleBackColor = true;
            this.buttonHeuComputer.Click += new System.EventHandler(this.buttonHeuComputer_Click);
            // 
            // buttonHeu9
            // 
            this.buttonHeu9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu9, "buttonHeu9");
            this.buttonHeu9.Name = "buttonHeu9";
            this.buttonHeu9.Tag = "9";
            this.buttonHeu9.UseVisualStyleBackColor = true;
            this.buttonHeu9.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu8
            // 
            this.buttonHeu8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu8, "buttonHeu8");
            this.buttonHeu8.Name = "buttonHeu8";
            this.buttonHeu8.Tag = "8";
            this.buttonHeu8.UseVisualStyleBackColor = true;
            this.buttonHeu8.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu7
            // 
            this.buttonHeu7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu7, "buttonHeu7");
            this.buttonHeu7.Name = "buttonHeu7";
            this.buttonHeu7.Tag = "7";
            this.buttonHeu7.UseVisualStyleBackColor = true;
            this.buttonHeu7.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu6
            // 
            this.buttonHeu6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu6, "buttonHeu6");
            this.buttonHeu6.Name = "buttonHeu6";
            this.buttonHeu6.Tag = "6";
            this.buttonHeu6.UseVisualStyleBackColor = true;
            this.buttonHeu6.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu5
            // 
            this.buttonHeu5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu5, "buttonHeu5");
            this.buttonHeu5.Name = "buttonHeu5";
            this.buttonHeu5.Tag = "5";
            this.buttonHeu5.UseVisualStyleBackColor = true;
            this.buttonHeu5.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu4
            // 
            this.buttonHeu4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu4, "buttonHeu4");
            this.buttonHeu4.Name = "buttonHeu4";
            this.buttonHeu4.Tag = "4";
            this.buttonHeu4.UseVisualStyleBackColor = true;
            this.buttonHeu4.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu3
            // 
            this.buttonHeu3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu3, "buttonHeu3");
            this.buttonHeu3.Name = "buttonHeu3";
            this.buttonHeu3.Tag = "3";
            this.buttonHeu3.UseVisualStyleBackColor = true;
            this.buttonHeu3.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu2
            // 
            this.buttonHeu2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu2, "buttonHeu2");
            this.buttonHeu2.Name = "buttonHeu2";
            this.buttonHeu2.Tag = "2";
            this.buttonHeu2.UseVisualStyleBackColor = true;
            this.buttonHeu2.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // buttonHeu1
            // 
            this.buttonHeu1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHeu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonHeu1, "buttonHeu1");
            this.buttonHeu1.Name = "buttonHeu1";
            this.buttonHeu1.Tag = "1";
            this.buttonHeu1.UseVisualStyleBackColor = true;
            this.buttonHeu1.Click += new System.EventHandler(this.buttonHeu_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGC,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // toolStripMenuItemGC
            // 
            this.toolStripMenuItemGC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.automaticToolStripMenuItem});
            this.toolStripMenuItemGC.Name = "toolStripMenuItemGC";
            resources.ApplyResources(this.toolStripMenuItemGC, "toolStripMenuItemGC");
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            resources.ApplyResources(this.manualToolStripMenuItem, "manualToolStripMenuItem");
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Checked = true;
            this.automaticToolStripMenuItem.CheckOnClick = true;
            this.automaticToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            resources.ApplyResources(this.automaticToolStripMenuItem, "automaticToolStripMenuItem");
            this.automaticToolStripMenuItem.Click += new System.EventHandler(this.automaticToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solveTicTacToeToolStripMenuItem,
            this.calculateUtilityFromBottomToolStripMenuItem,
            this.toolStripSeparator,
            this.initialPlayerToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            resources.ApplyResources(this.actionsToolStripMenuItem, "actionsToolStripMenuItem");
            // 
            // solveTicTacToeToolStripMenuItem
            // 
            this.solveTicTacToeToolStripMenuItem.Name = "solveTicTacToeToolStripMenuItem";
            resources.ApplyResources(this.solveTicTacToeToolStripMenuItem, "solveTicTacToeToolStripMenuItem");
            this.solveTicTacToeToolStripMenuItem.Click += new System.EventHandler(this.solveTicTacToeToolStripMenuItem_Click);
            // 
            // calculateUtilityFromBottomToolStripMenuItem
            // 
            this.calculateUtilityFromBottomToolStripMenuItem.Name = "calculateUtilityFromBottomToolStripMenuItem";
            resources.ApplyResources(this.calculateUtilityFromBottomToolStripMenuItem, "calculateUtilityFromBottomToolStripMenuItem");
            this.calculateUtilityFromBottomToolStripMenuItem.Click += new System.EventHandler(this.calculateUtilityFromBottomToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // initialPlayerToolStripMenuItem
            // 
            this.initialPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1StartsToolStripMenuItem,
            this.player2StartsToolStripMenuItem});
            this.initialPlayerToolStripMenuItem.Name = "initialPlayerToolStripMenuItem";
            resources.ApplyResources(this.initialPlayerToolStripMenuItem, "initialPlayerToolStripMenuItem");
            // 
            // player1StartsToolStripMenuItem
            // 
            this.player1StartsToolStripMenuItem.Checked = true;
            this.player1StartsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player1StartsToolStripMenuItem.Name = "player1StartsToolStripMenuItem";
            resources.ApplyResources(this.player1StartsToolStripMenuItem, "player1StartsToolStripMenuItem");
            this.player1StartsToolStripMenuItem.Click += new System.EventHandler(this.player1StartsToolStripMenuItem_Click);
            // 
            // player2StartsToolStripMenuItem
            // 
            this.player2StartsToolStripMenuItem.Name = "player2StartsToolStripMenuItem";
            resources.ApplyResources(this.player2StartsToolStripMenuItem, "player2StartsToolStripMenuItem");
            this.player2StartsToolStripMenuItem.Click += new System.EventHandler(this.player2StartsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.minmaxToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // minmaxToolStripMenuItem
            // 
            this.minmaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomStartToolStripMenuItem,
            this.startAtcenterToolStripMenuItem});
            this.minmaxToolStripMenuItem.Name = "minmaxToolStripMenuItem";
            resources.ApplyResources(this.minmaxToolStripMenuItem, "minmaxToolStripMenuItem");
            // 
            // randomStartToolStripMenuItem
            // 
            this.randomStartToolStripMenuItem.Name = "randomStartToolStripMenuItem";
            resources.ApplyResources(this.randomStartToolStripMenuItem, "randomStartToolStripMenuItem");
            this.randomStartToolStripMenuItem.Click += new System.EventHandler(this.randomStartToolStripMenuItem_Click);
            // 
            // startAtcenterToolStripMenuItem
            // 
            this.startAtcenterToolStripMenuItem.Checked = true;
            this.startAtcenterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startAtcenterToolStripMenuItem.Name = "startAtcenterToolStripMenuItem";
            resources.ApplyResources(this.startAtcenterToolStripMenuItem, "startAtcenterToolStripMenuItem");
            this.startAtcenterToolStripMenuItem.Click += new System.EventHandler(this.startAtcenterToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxSolutionBrowser.ResumeLayout(false);
            this.groupBoxSolutionBrowser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMinMaxDetails.ResumeLayout(false);
            this.groupBoxMinMaxDetails.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxHeuDetails.ResumeLayout(false);
            this.groupBoxHeuDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBoxSolutionBrowser;
        private System.Windows.Forms.TextBox textBoxParent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSubIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBoardDeeper;
        private System.Windows.Forms.Button buttonBoardNext;
        private System.Windows.Forms.Button buttonBoardPrevious;
        private System.Windows.Forms.Button buttonBoard8;
        private System.Windows.Forms.Button buttonBoard7;
        private System.Windows.Forms.Button buttonBoard5;
        private System.Windows.Forms.Button buttonBoard4;
        private System.Windows.Forms.Button buttonBoard6;
        private System.Windows.Forms.Button buttonBoard3;
        private System.Windows.Forms.Button buttonBoard2;
        private System.Windows.Forms.Button buttonBoard1;
        private System.Windows.Forms.Button buttonBoard0;
        private System.Windows.Forms.Button buttonBoardParent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveTicTacToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateUtilityFromBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem initialPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1StartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player2StartsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMinMax9;
        private System.Windows.Forms.Button buttonMinMax8;
        private System.Windows.Forms.Button buttonMinMax7;
        private System.Windows.Forms.Button buttonMinMax6;
        private System.Windows.Forms.Button buttonMinMax5;
        private System.Windows.Forms.Button buttonMinMax4;
        private System.Windows.Forms.Button buttonMinMax3;
        private System.Windows.Forms.Button buttonMinMax2;
        private System.Windows.Forms.Button buttonMinMax1;
        private System.Windows.Forms.Button buttonMinMaxReset;
        private System.Windows.Forms.Button buttonMinMaxComputer;
        private System.Windows.Forms.Label labelMinMax;
        private System.Windows.Forms.CheckBox checkBoxMinMaxDelay;
        private System.Windows.Forms.CheckBox checkBoxMinMaxDetails;
        private System.Windows.Forms.GroupBox groupBoxMinMaxDetails;
        private System.Windows.Forms.TextBox textBoxMinMaxTurn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMinMaxDepth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMinMaxWeight;
        private System.Windows.Forms.TextBox textBoxMinMaxParent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelHeu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxHeuDetails;
        private System.Windows.Forms.TextBox textBoxHeuTurn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxHeuDepth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxHeuWeight;
        private System.Windows.Forms.TextBox textBoxHeuParent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxHeuDetails;
        private System.Windows.Forms.CheckBox checkBoxHeuDelay;
        private System.Windows.Forms.Button buttonHeuReset;
        private System.Windows.Forms.Button buttonHeuComputer;
        private System.Windows.Forms.Button buttonHeu9;
        private System.Windows.Forms.Button buttonHeu8;
        private System.Windows.Forms.Button buttonHeu7;
        private System.Windows.Forms.Button buttonHeu6;
        private System.Windows.Forms.Button buttonHeu5;
        private System.Windows.Forms.Button buttonHeu4;
        private System.Windows.Forms.Button buttonHeu3;
        private System.Windows.Forms.Button buttonHeu2;
        private System.Windows.Forms.Button buttonHeu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minmaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAtcenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStatistics;

    }
}

