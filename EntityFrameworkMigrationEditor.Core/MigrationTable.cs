using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityFrameworkMigrationEditor.Core
{
    public class MigrationTable : MigrationLightTable
    {
        public byte[] Model { get; set; }
        public XDocument GetXml()
        {
            if (Model != null && Model.Length > 0)
            {
                var xml = Model.Decompress();
                return xml;
            }
        }
    }
}
