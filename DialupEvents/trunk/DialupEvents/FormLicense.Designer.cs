namespace DialupEvents
{
    partial class FormLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicense));
            this.buttonRejectLicence = new System.Windows.Forms.Button();
            this.buttonAcceptLicence = new System.Windows.Forms.Button();
            this.richTextBoxLicence = new System.Windows.Forms.RichTextBox();
            this.buttonSaveLicence = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // buttonRejectLicence
            // 
            resources.ApplyResources(this.buttonRejectLicence, "buttonRejectLicence");
            this.buttonRejectLicence.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRejectLicence.Name = "buttonRejectLicence";
            this.buttonRejectLicence.UseVisualStyleBackColor = true;
            this.buttonRejectLicence.Click += new System.EventHandler(this.buttonRejectLicence_Click);
            // 
            // buttonAcceptLicence
            // 
            resources.ApplyResources(this.buttonAcceptLicence, "buttonAcceptLicence");
            this.buttonAcceptLicence.Name = "buttonAcceptLicence";
            this.buttonAcceptLicence.UseVisualStyleBackColor = true;
            this.buttonAcceptLicence.Click += new System.EventHandler(this.buttonAcceptLicence_Click);
            // 
            // richTextBoxLicence
            // 
            resources.ApplyResources(this.richTextBoxLicence, "richTextBoxLicence");
            this.richTextBoxLicence.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxLicence.Name = "richTextBoxLicence";
            this.richTextBoxLicence.ReadOnly = true;
            // 
            // buttonSaveLicence
            // 
            resources.ApplyResources(this.buttonSaveLicence, "buttonSaveLicence");
            this.buttonSaveLicence.Name = "buttonSaveLicence";
            this.buttonSaveLicence.UseVisualStyleBackColor = true;
            this.buttonSaveLicence.Click += new System.EventHandler(this.buttonPrintLicence_Click);
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Name = "printPreviewDialog";
            // 
            // FormLicense
            // 
            this.AcceptButton = this.buttonRejectLicence;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.buttonSaveLicence);
            this.Controls.Add(this.richTextBoxLicence);
            this.Controls.Add(this.buttonAcceptLicence);
            this.Controls.Add(this.buttonRejectLicence);
            this.Name = "FormLicense";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FormLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRejectLicence;
        private System.Windows.Forms.Button buttonAcceptLicence;
        private System.Windows.Forms.RichTextBox richTextBoxLicence;
        private System.Windows.Forms.Button buttonSaveLicence;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}