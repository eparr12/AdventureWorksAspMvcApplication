using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AdventureWorksAspMvcUI.Models
{
    public class VendorAccessoriesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }
        [Display(Name = "Product Line")]
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }
        [Display(Name = "Sub-Category")]
        public string SubCategory { get; set; }
        public string Model { get; set; }
        public int Qty { get; set; }


        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal VendorPrice
        {
            get
            {
                return ListPrice * decimal.Parse("0.8");
            }
        }
    }
}
