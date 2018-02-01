using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMigrationEditor.Core
{
    public class MigrationSetting
    {
        public string MigrationIdName { get; set; }
        public string ContextKeyName { get; set; }
        public string ProductVersionName { get; set; }
        public string ModelName { get; set; }
        public string MigrationTableName { get; set; }
        public MigrationSetting()
        {

        }
        public MigrationSetting(bool useDefaultValues)
        {
            if (useDefaultValues)
                SetDefaultValue();
        }
        public virtual void SetDefaultValue()
        {
            this.MigrationIdName = "MigrationId";
            this.ContextKeyName = "ContextKey";
            this.ProductVersionName = "Model";
            this.ModelName = "ProductVersion";
            this.MigrationTableName = "__MigrationHistory";
        }
    }
}
