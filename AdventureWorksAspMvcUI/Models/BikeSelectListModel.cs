using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AdventureWorksAspMvcUI.Models
{
    public class BikeSelectListModel
    {
        public string SelectedBike { get; set; }
        public List<SelectListItem> BikesSelectList { get; set; }
    }
}
