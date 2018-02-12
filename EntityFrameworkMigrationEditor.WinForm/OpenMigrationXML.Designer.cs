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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenMigrationXML));
            this.txtMigrationDataXml = new System.Windows.Forms.RichTextBox();
            this.sfdDownloadXml = new System.Windows.Forms.SaveFileDialog();
            this.txtProductVersion = new MetroFramework.Controls.MetroTextBox();
            this.txtContextKeyName = new MetroFramework.Controls.MetroTextBox();
            this.btnCopy = new MetroFramework.Controls.MetroTile();
            this.btnDownload = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.notifyGeneral = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txtMigrationDataXml
            // 
            this.txtMigrationDataXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMigrationDataXml.Location = new System.Drawing.Point(8, 107);
            this.txtMigrationDataXml.Name = "txtMigrationDataXml";
            this.txtMigrationDataXml.Size = new System.Drawing.Size(735, 387);
            this.txtMigrationDataXml.TabIndex = 0;
            this.txtMigrationDataXml.Text = "";
            // 
            // sfdDownloadXml
            // 
            this.sfdDownloadXml.Filter = "XML|*.xml";
            this.sfdDownloadXml.Title = "Save XML Path";
            // 
            // txtProductVersion
            // 
            this.txtProductVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtProductVersion.CustomButton.Image = null;
            this.txtProductVersion.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtProductVersion.CustomButton.Name = "";
            this.txtProductVersion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductVersion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductVersion.CustomButton.TabIndex = 1;
            this.txtProductVersion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductVersion.CustomButton.UseSelectable = true;
            this.txtProductVersion.CustomButton.Visible = false;
            this.txtProductVersion.Lines = new string[0];
            this.txtProductVersion.Location = new System.Drawing.Point(554, 78);
            this.txtProductVersion.MaxLength = 32767;
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.PasswordChar = '\0';
            this.txtProductVersion.ReadOnly = true;
            this.txtProductVersion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductVersion.SelectedText = "";
            this.txtProductVersion.SelectionLength = 0;
            this.txtProductVersion.SelectionStart = 0;
            this.txtProductVersion.ShortcutsEnabled = true;
            this.txtProductVersion.Size = new System.Drawing.Size(189, 23);
            this.txtProductVersion.TabIndex = 3;
            this.txtProductVersion.UseSelectable = true;
            this.txtProductVersion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductVersion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductVersion.DoubleClick += new System.EventHandler(this.txtProductVersion_DoubleClick);
            // 
            // txtContextKeyName
            // 
            this.txtContextKeyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtContextKeyName.CustomButton.Image = null;
            this.txtContextKeyName.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtContextKeyName.CustomButton.Name = "";
            this.txtContextKeyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContextKeyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContextKeyName.CustomButton.TabIndex = 1;
            this.txtContextKeyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContextKeyName.CustomButton.UseSelectable = true;
            this.txtContextKeyName.CustomButton.Visible = false;
            this.txtContextKeyName.Lines = new string[0];
            this.txtContextKeyName.Location = new System.Drawing.Point(353, 78);
            this.txtContextKeyName.MaxLength = 32767;
            this.txtContextKeyName.Name = "txtContextKeyName";
            this.txtContextKeyName.PasswordChar = '\0';
            this.txtContextKeyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContextKeyName.SelectedText = "";
            this.txtContextKeyName.SelectionLength = 0;
            this.txtContextKeyName.SelectionStart = 0;
            this.txtContextKeyName.ShortcutsEnabled = true;
            this.txtContextKeyName.Size = new System.Drawing.Size(189, 23);
            this.txtContextKeyName.TabIndex = 4;
            this.txtContextKeyName.UseSelectable = true;
            this.txtContextKeyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContextKeyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContextKeyName.DoubleClick += new System.EventHandler(this.txtProductVersion_DoubleClick);
            // 
            // btnCopy
            // 
            this.btnCopy.ActiveControl = null;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Location = new System.Drawing.Point(198, 63);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(71, 38);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.TileImage = global::EntityFrameworkMigrationEditor.WinForm.Properties.Resources.copy;
            this.btnCopy.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.UseSelectable = true;
            this.btnCopy.UseTileImage = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.ActiveControl = null;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Location = new System.Drawing.Point(87, 63);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(98, 38);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.TileImage = global::EntityFrameworkMigrationEditor.WinForm.Properties.Resources.cloud_computing;
            this.btnDownload.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.UseSelectable = true;
            this.btnDownload.UseTileImage = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(8, 63);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TileImage = global::EntityFrameworkMigrationEditor.WinForm.Properties.Resources.save;
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // notifyGeneral
            // 
            this.notifyGeneral.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyGeneral.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyGeneral.Icon")));
            this.notifyGeneral.Visible = true;
            // 
            // OpenMigrationXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 517);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtContextKeyName);
            this.Controls.Add(this.txtProductVersion);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMigrationDataXml);
            this.Name = "OpenMigrationXML";
            this.Text = "OpenMigrationXML";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMigrationDataXml;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnDownload;
        private System.Windows.Forms.SaveFileDialog sfdDownloadXml;
        private MetroFramework.Controls.MetroTextBox txtProductVersion;
        private MetroFramework.Controls.MetroTextBox txtContextKeyName;
        private MetroFramework.Controls.MetroTile btnCopy;
        private System.Windows.Forms.NotifyIcon notifyGeneral;
    }
}