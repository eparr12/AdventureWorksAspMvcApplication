using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AdventureWorksAspMvcUI.Models
{
    public class ClothingModel
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

        [Display(Name = "Product Line")]
        public string ProductLine { get; set; }
        public string Category { get; set; }

        [Display(Name = "Sub-Category")]
        public string SubCategory { get; set; }
        public string Model { get; set; }
        public int Qty { get; set; }
    }
}
