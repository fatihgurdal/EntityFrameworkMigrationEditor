using EntityFrameworkMigrationEditor.Core;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkMigrationEditor.WinForm
{
    public partial class EditMigrationSetting : MetroForm
    {
        private Setting tempSetting;
        private bool _isUpdate;
        public EditMigrationSetting(Setting setting, bool isUpdate)
        {
            InitializeComponent();
            this.cbSQLServerType.DataSource = Enum.GetValues(typeof(ServerType));
            this.tempSetting = setting;
            _isUpdate = isUpdate;
            txtConnectionName.Text = setting.ConnectionName;
            txtConnectionString.Text = setting.ConnectionString;
            txtContextKey.Text = setting.ContextKeyName;
            txtMigrationId.Text = setting.MigrationIdName;
            txtMigrationTable.Text = setting.MigrationTableName;
            txtModel.Text = setting.ModelName;
            txtProductVersion.Text = setting.ProductVersionName;
            this.cbSQLServerType.SelectedItem = setting.ServerType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = Setting.GetSettings(MainForm.settingPath);

            tempSetting.ConnectionName = txtConnectionName.Text;
            tempSetting.ConnectionString = txtConnectionString.Text;
            tempSetting.ContextKeyName = txtContextKey.Text;
            tempSetting.MigrationIdName = txtMigrationId.Text;
            tempSetting.MigrationTableName = txtMigrationTable.Text;
            tempSetting.ModelName = txtModel.Text;
            tempSetting.ProductVersionName = txtProductVersion.Text;
            tempSetting.ServerType = (ServerType)cbSQLServerType.SelectedItem;
            if (this._isUpdate == false)
            {
                list.Add(tempSetting);
                list.SaveSettings(MainForm.settingPath);
            }
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void btnConnectionTest_Click(object sender, EventArgs e)
        {
            var migrationConnection = new MigrationConnection(txtConnectionString.Text, txtMigrationTable.Text, (ServerType)cbSQLServerType.SelectedItem);
            string error;
            if (migrationConnection.TestConnection(out error))
            {

                MetroMessageBox.Show(this, "Connection Success...", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, error, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
