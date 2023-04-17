using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AdventureWorksAspMvcUI.Models
{
    public class VendorBikeAndComponentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public Decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public Decimal Weight { get; set; }

        [Display(Name = "Product Line")]
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }

        [Display(Name = "Sub Category")]
        public string SubCategory { get; set; }
        public string Model { get; set; }
        public int Qty { get; set; }

        public string FormatSize
        {
            get
            {
                if (Size == "N/A" || Size == "n/a")
                {
                    return "N/A";
                }
                else
                {
                    return string.Concat(Size, SizeUnitMeasureCode.ToLower());
                }
            }
        }

        [Display(Name = "Weight")]
        public string FormatWeight
        {
            get
            {
                return string.Concat(Weight, WeightUnitMeasureCode.ToLower());
            }
        }

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
