using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }
        public string OrderDate { get; set; }
        public string TotalAmount { get; set; }
    }
}
