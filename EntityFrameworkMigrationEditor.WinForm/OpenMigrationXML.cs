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
using System.Xml.Linq;

namespace EntityFrameworkMigrationEditor.WinForm
{
    public partial class OpenMigrationXML : MetroForm
    {
        public MigrationTable MigrationTable { get; private set; }
        public Setting _setting { get; private set; }
        public OpenMigrationXML(MigrationTable migTable, Setting setting)
        {
            InitializeComponent();
            this.MigrationTable = migTable;
            this._setting = setting;
            var xmlDocument = MigrationTable.Model.Decompress();
            txtMigrationDataXml.Text = xmlDocument.ToString();
            txtContextKeyName.Text = migTable.ContextKey;
            txtProductVersion.Text = migTable.ProductVersion;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var migConnection = new MigrationConnection(_setting.ConnectionString, _setting.MigrationTableName, _setting.ServerType);
            var document = XDocument.Parse(txtMigrationDataXml.Text);
            migConnection.UpdateMigration(this.MigrationTable.MigrationId, document, _setting);
            migConnection.UpdateMigration(this.MigrationTable, _setting);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            sfdDownloadXml.FileName = this.MigrationTable.MigrationId + ".xml";
            if (sfdDownloadXml.ShowDialog() == DialogResult.OK)
            {
                var path = sfdDownloadXml.FileName;
                var document = XDocument.Parse(txtMigrationDataXml.Text);
                document.Save(path);
                if (MetroMessageBox.Show(this, "Do you open the xml file?", "Open", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@path);
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMigrationDataXml.Text);
            //MetroMessageBox.Show(this, "Copy", "Copy XML");
            notifyGeneral.ShowBalloonTip(3000, "Entity Framework Editor", "XML Copy to Clipboard",ToolTipIcon.Info);
        }

        private void txtProductVersion_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}
