using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AdventureWorksAspMvcUI.Models
{
    public class BikeAndComponentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }
        public string Color { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public Decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public Decimal Weight { get; set; }

        [Display(Name = "Product Line")]
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }

        [Display(Name = "Sub-Category")]
        public string SubCategory { get; set; }
        public string Model { get; set; }
        public int Qty { get; set; }

        [Display(Name = "Size")]
        public string FormatSize
        {
            get
            {
                if (SizeUnitMeasureCode != null)
                {
                    return string.Concat(Size, SizeUnitMeasureCode.ToLower());
                }

                return string.Empty;
            }
        }

        [Display(Name = "Weight")]
        public string FormatWeight
        {
            get
            {
                if (WeightUnitMeasureCode != null)
                {
                    return string.Concat(Weight, WeightUnitMeasureCode.ToLower());
                }

                return string.Empty;
            }
        }
    }
}
