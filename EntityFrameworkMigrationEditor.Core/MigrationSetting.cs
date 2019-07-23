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
        public ServerType ServerType { get; set; }
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
            this.ProductVersionName = "ProductVersion";
            this.ModelName = "Model";
            this.MigrationTableName = "__MigrationHistory";
            this.ServerType = ServerType.SQLServer;
        }
        public Dictionary<string,string> GetColumns()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("MigrationId", this.MigrationIdName);
            dic.Add("ContextKey", this.ContextKeyName);
            dic.Add("ProductVersion", ProductVersionName);
            dic.Add("Model", ModelName);
            dic.Add("__MigrationHistory", MigrationTableName);
            return dic;
        }
    }
    public enum ServerType : byte
    {
        SQLServer = 0,
        Oracle = 1,
        New = 255
    }
}
