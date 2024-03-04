using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class LogEvent
    {
        public string id { get; set; }
        public string compId { get; set; }
        public string eventType { get; set; }
        public DateTime time { get; set; }
    }
}
