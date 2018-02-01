namespace EntityFrameworkMigrationEditor.WinForm
{
    partial class MainForm
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
            this.cbMigrations = new MetroFramework.Controls.MetroComboBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnGetMigrations = new MetroFramework.Controls.MetroButton();
            this.lbMigrations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbMigrations
            // 
            this.cbMigrations.FormattingEnabled = true;
            this.cbMigrations.ItemHeight = 23;
            this.cbMigrations.Location = new System.Drawing.Point(23, 63);
            this.cbMigrations.Name = "cbMigrations";
            this.cbMigrations.Size = new System.Drawing.Size(265, 29);
            this.cbMigrations.TabIndex = 0;
            this.cbMigrations.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(294, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(348, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetMigrations
            // 
            this.btnGetMigrations.Location = new System.Drawing.Point(402, 63);
            this.btnGetMigrations.Name = "btnGetMigrations";
            this.btnGetMigrations.Size = new System.Drawing.Size(95, 29);
            this.btnGetMigrations.TabIndex = 4;
            this.btnGetMigrations.Text = "Get Migrations";
            this.btnGetMigrations.UseSelectable = true;
            this.btnGetMigrations.Click += new System.EventHandler(this.btnGetMigrations_Click);
            // 
            // lbMigrations
            // 
            this.lbMigrations.FormattingEnabled = true;
            this.lbMigrations.Location = new System.Drawing.Point(23, 98);
            this.lbMigrations.Name = "lbMigrations";
            this.lbMigrations.Size = new System.Drawing.Size(575, 342);
            this.lbMigrations.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 461);
            this.Controls.Add(this.lbMigrations);
            this.Controls.Add(this.btnGetMigrations);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbMigrations);
            this.Name = "MainForm";
            this.Text = "Migration Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbMigrations;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnGetMigrations;
        private System.Windows.Forms.ListBox lbMigrations;
    }
}

