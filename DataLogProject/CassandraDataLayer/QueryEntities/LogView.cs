using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class LogView
    {
        public string id { get; set; }
        public string compId { get; set; }
        public string subjectName { get; set; }
        public string viewType { get; set; }
        public DateTime time { get; set; }
    }
}
