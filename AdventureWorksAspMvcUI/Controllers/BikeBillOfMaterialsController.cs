using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    [Authorize(Roles = "Administrator, Vendor")]
    public class BikeBillOfMaterialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: ComponentsController/Details/5
        //GET: Bike Bill Of Materials
        public ActionResult BikeBillOfMaterials(BikeSelectListModel model)
        {
            var selectedBike = model.SelectedBike.ToString();

            ViewBag.Message = "Bike Bill Of Materials";

            var billOfMaterials = BikeBillOfMaterialsProcessor.LoadBikeBillOfMaterials(int.Parse(selectedBike));

            List<BikeBillOfMaterialsModel> BillOfMaterials = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeBillOfMaterialsModel, BikeBillOfMaterialsModel>());
            var mapper = new Mapper(config);
            var listBillOfMaterials = mapper.Map<List<BikeBillOfMaterialsModel>>(billOfMaterials);

            foreach (BikeBillOfMaterialsModel e in listBillOfMaterials)
            {
                BillOfMaterials.Add(e);
            }

            return View("Views/BikeBillOfMaterials/BikeBillOfMaterials.cshtml", BillOfMaterials);
        }
    }
}
