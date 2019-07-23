using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMigrationEditor.Core
{
    public class MigrationLightTable
    {
        public string MigrationId { get; set; }
        public string ContextKey { get; set; }
        public string ProductVersion { get; set; }

        public MigrationLightTable()
        {

        }
        public override string ToString()
        {
            return $"{MigrationId} & {ContextKey} & {ProductVersion}";
        }
        public MigrationTable GetMigrationTable(Setting setting)
        {
            var migCon = new MigrationConnection(setting.ConnectionString, setting.MigrationTableName, setting.ServerType);
            return migCon.GetMigrationWithData(this.MigrationId, setting);
        }

    }
}
