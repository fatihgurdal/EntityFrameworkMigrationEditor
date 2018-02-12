using EntityFrameworkMigrationEditor.Core;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkMigrationEditor.WinForm
{
    public partial class MainForm : MetroForm
    {
        internal const string settingPath = "settings.json";
        public static List<Setting> Connections { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            LoadSettings();

        }

        private void LoadSettings()
        {
            if (File.Exists(settingPath) == false)
            {
                new List<Setting>().SaveSettings(settingPath);
            }
            Connections = Setting.GetSettings(settingPath);
            cbMigrations.DataSource = Connections;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EditMigrationSetting(new Setting(true), false);
            this.Hide();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSettings();
            }
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var set = new Setting(true);
            var isUpdate = false;
            if (cbMigrations.SelectedItem != null)
            {
                set = (Setting)cbMigrations.SelectedItem;
                isUpdate = true;
            }
            var form = new EditMigrationSetting(set, isUpdate);
            this.Hide();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (isUpdate)
                {
                    var list = (List<Setting>)cbMigrations.DataSource;
                    list.SaveSettings(MainForm.settingPath);
                }
                LoadSettings();
            }
            this.Show();
        }

        private void btnGetMigrations_Click(object sender, EventArgs e)
        {
            if (cbMigrations.SelectedItem != null)
            {
                var set = (Setting)cbMigrations.SelectedItem;
                var migConnection = new MigrationConnection(set.ConnectionString, set.MigrationTableName);
                var migration = migConnection.GetMigrations(set);
                lbMigrations.DataSource = migration;
            }
        }

        private void lbMigrations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = (MigrationLightTable)(((ListBox)sender).SelectedItem);
            var setting = (Setting)(cbMigrations.SelectedItem);
            if (selected != null && setting != null)
            {
                var form = new OpenMigrationXML(selected.GetMigrationTable(setting), setting);
                this.Hide();
                form.Text = selected.MigrationId;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSettings();
                }
                this.Show();

            }
        }
    }
}
