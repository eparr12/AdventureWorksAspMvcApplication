using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.Models
{
    public class SalesOrderDetailModel
    {
        public int SalesOrderID { get; set; }
        public int OrderQty { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
