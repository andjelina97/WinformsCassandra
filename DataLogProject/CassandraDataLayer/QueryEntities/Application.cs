using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Application
    {
        public string id { get; set; }
        public string appName { get; set; }
        public string appType { get; set; }
        public string purposeOfApp { get; set; }
        public string termsOfUse { get; set; }

        public string AppName
        {
            get { return appName; }
            set { appName = value; }
        }
    }
}
