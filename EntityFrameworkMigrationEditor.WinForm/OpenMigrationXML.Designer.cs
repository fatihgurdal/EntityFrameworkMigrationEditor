namespace EntityFrameworkMigrationEditor.WinForm
{
    partial class OpenMigrationXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMigrationDataXml = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtMigrationDataXml
            // 
            this.txtMigrationDataXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMigrationDataXml.Location = new System.Drawing.Point(8, 120);
            this.txtMigrationDataXml.Name = "txtMigrationDataXml";
            this.txtMigrationDataXml.Size = new System.Drawing.Size(735, 374);
            this.txtMigrationDataXml.TabIndex = 0;
            this.txtMigrationDataXml.Text = "";
            // 
            // OpenMigrationXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 517);
            this.Controls.Add(this.txtMigrationDataXml);
            this.Name = "OpenMigrationXML";
            this.Text = "OpenMigrationXML";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMigrationDataXml;
    }
}