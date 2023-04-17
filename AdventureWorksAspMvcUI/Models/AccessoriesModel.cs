using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace AdventureWorksAspMvcUI.Models
{
    public class AccessoriesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        [Display (Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal ListPrice { get; set; }
        [Display(Name = "Product Line")]
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }
        [Display(Name = "Sub-Category")]
        public string SubCategory { get; set; }
        public string Model { get; set; }
        public string Qty { get; set; }
    }
}
