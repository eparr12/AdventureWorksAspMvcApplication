using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.Models
{
    public class VendorSalesOrderModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ShipMethod { get; set; }
        public decimal Freight { get; set; }
        public int SalesOrderID { get; set; }
    }
}
