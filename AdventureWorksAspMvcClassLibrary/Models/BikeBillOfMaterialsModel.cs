using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.Models
{
    public class BikeBillOfMaterialsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int TotalQuantity { get; set; }
        public int ListPrice { get; set; }
        public int BOMLevel { get; set; }
    }
}
