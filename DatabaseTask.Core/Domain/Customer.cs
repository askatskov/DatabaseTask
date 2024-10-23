using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string JoinDate { get; set; }
        public IEnumerable<Order> Orders { get; set; } = new List<Order>();

    }
}
