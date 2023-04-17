using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    [Authorize(Roles = "Administrator, Vendor")]
    public class VendorBikesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //VendorBikes Sub-Categories

        // GET: Vendor Mountain Bikes
        public ActionResult MountainBikes()
        {
            ViewBag.Message = "Mountain Bikes";

            var mountainBikes = BikesProcessor.LoadMountainBikes();

            List<VendorBikeAndComponentModel> MountainBikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listMountainBikes = mapper.Map<List<VendorBikeAndComponentModel>>(mountainBikes);

            foreach (VendorBikeAndComponentModel e in listMountainBikes)
            {
                MountainBikes.Add(e);
            }

            return View("Views/VendorBikes/VendorMountainBikes.cshtml", MountainBikes);
        }

        // GET: Vendor Road Bikes
        public ActionResult RoadBikes()
        {
            ViewBag.Message = "Road Bikes";

            var roadBikes = BikesProcessor.LoadRoadBikes();

            List<VendorBikeAndComponentModel> RoadBikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listRoadBikes = mapper.Map<List<VendorBikeAndComponentModel>>(roadBikes);

            foreach (VendorBikeAndComponentModel e in listRoadBikes)
            {
                RoadBikes.Add(e);
            }

            return View("Views/VendorBikes/VendorRoadBikes.cshtml", RoadBikes);
        }

        // GET: Vendor Touring Bikes
        public ActionResult TouringBikes()
        {
            ViewBag.Message = "Touring Bikes";

            var touringBikes = BikesProcessor.LoadTouringBikes();

            List<VendorBikeAndComponentModel> TouringBikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listTouringBikes = mapper.Map<List<VendorBikeAndComponentModel>>(touringBikes);

            foreach (VendorBikeAndComponentModel e in listTouringBikes)
            {
                TouringBikes.Add(e);
            }

            return View("Views/VendorBikes/VendorTouringBikes.cshtml", TouringBikes);
        }
    }
}
