using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    public class BikesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Bikes Sub-Categories

        // GET: Mountain Bikes
        public ActionResult MountainBikes()
        {
            ViewBag.Message = "Mountain Bikes";

            var mountainBikes = BikesProcessor.LoadMountainBikes();

            List<BikeAndComponentModel> MountainBikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, BikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listMountainBikes = mapper.Map<List<BikeAndComponentModel>>(mountainBikes);
            foreach (BikeAndComponentModel e in listMountainBikes)
            {
                MountainBikes.Add(e);
            }
            return View("Views/Bikes/MountainBikes.cshtml", MountainBikes);
        }

        // GET: Road Bikes
        public ActionResult RoadBikes()
        {
            ViewBag.Message = "Road Bikes";

            var roadBikes = BikesProcessor.LoadRoadBikes();

            List<BikeAndComponentModel> RoadBikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, BikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listRoadBikes = mapper.Map<List<BikeAndComponentModel>>(roadBikes);

            foreach (BikeAndComponentModel e in listRoadBikes)
            {
                RoadBikes.Add(e);
            }

            return View("Views/Bikes/RoadBikes.cshtml", RoadBikes);
        }

        // GET: Touring Bikes
        public ActionResult TouringBikes()
        {
            ViewBag.Message = "Touring Bikes";

            var touringBikes = BikesProcessor.LoadTouringBikes();

            List<BikeAndComponentModel> TouringBikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, BikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listTouringBikes = mapper.Map<List<BikeAndComponentModel>>(touringBikes);

            foreach (BikeAndComponentModel e in listTouringBikes)
            {
                TouringBikes.Add(e);
            }

            return View("Views/Bikes/TouringBikes.cshtml", TouringBikes);
        }
    }
}
