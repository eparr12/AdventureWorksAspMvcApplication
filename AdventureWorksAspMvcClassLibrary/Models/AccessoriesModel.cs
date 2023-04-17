using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.Models
{
    public class AccessoriesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Model { get; set; }
    }
}
