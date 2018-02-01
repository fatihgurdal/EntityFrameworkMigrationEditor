using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMigrationEditor.Core
{
    public class Setting : MigrationSetting
    {
        public string ConnectionString { get; set; }

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
            return CandyFramework.Common.Converter.XMLSerializer.XmlStringDesrializer<List<Setting>>(path);
        }
    }
}
