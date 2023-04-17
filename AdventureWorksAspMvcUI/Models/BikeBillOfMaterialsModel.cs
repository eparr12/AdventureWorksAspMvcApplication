using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AdventureWorksAspMvcUI.Models
{
    public class BikeBillOfMaterialsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }

        [Display(Name = "Total Quantity")]
        public int TotalQuantity { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public int ListPrice { get; set; }

        [Display(Name = "BOM Level")]
        public int BOMLevel { get; set; }
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
