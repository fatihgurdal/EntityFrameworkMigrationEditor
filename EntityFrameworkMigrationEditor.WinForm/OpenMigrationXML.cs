using EntityFrameworkMigrationEditor.Core;
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
    public partial class OpenMigrationXML : MetroForm
    {
        public MigrationTable MigrationTable { get; private set; }
        public OpenMigrationXML(MigrationTable migTable)
        {
            InitializeComponent();
            this.MigrationTable = migTable;
            var xmlDocument = MigrationTable.Model.Decompress();
            txtMigrationDataXml.Text = xmlDocument.ToString();
        }
    }
}
