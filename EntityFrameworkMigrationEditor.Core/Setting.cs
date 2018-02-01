using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntityFrameworkMigrationEditor.Core
{
    public class Setting : MigrationSetting
    {
        public string ConnectionString { get; set; }
        public string ConnectionName { get; set; }

        public Setting() : this(false)
        {

        }
        public Setting(bool useDefaultValues)
        {
            if (useDefaultValues)
                SetDefaultValue();
        }
        public override void SetDefaultValue()
        {
            base.SetDefaultValue();
            this.ConnectionString = "";
        }
        public static List<Setting> GetSettings(string path)
        {
            var jsonString = File.ReadAllText(path);
            var result= CandyFramework.Common.Converter.JsonSerializer.JSONDeserialize<List<Setting>>(jsonString);
            return result;
        }
        public override string ToString()
        {
            return this.ConnectionName;
        }
    }
}
