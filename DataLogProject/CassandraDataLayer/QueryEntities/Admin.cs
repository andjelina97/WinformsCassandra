using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Admin
    {
        public string id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phonenumber { get; set; }
    }
}
