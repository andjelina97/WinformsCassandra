using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Customer
    {
        public String applicationId { get; set; }
        public String username { get; set; }

        public Customer(string applicationId, string username)
        {
            this.applicationId = applicationId;
            this.username = username;
        }
    }
}
