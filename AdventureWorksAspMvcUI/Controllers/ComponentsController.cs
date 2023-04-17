using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    [Authorize(Roles = "Administrator, Vendor")]
    public class ComponentsController : Controller
    {
        // GET: ComponentsController
        public ActionResult Index()
        {
            return View();
        }

        //Components Sub-Categories

        // GET: Bottom Brackets
        public ActionResult BottomBrackets()
        {
            ViewBag.Message = "Bottom Brackets";

            var bottomBrackets = ComponentsProcessor.LoadBottomBrackets();

            List<VendorBikeAndComponentModel> BottomBrackets = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listBottomBrackets = mapper.Map<List<VendorBikeAndComponentModel>>(bottomBrackets);

            foreach (VendorBikeAndComponentModel e in listBottomBrackets)
            {
                BottomBrackets.Add(e);
            }

            return View("Views/Components/BottomBrackets.cshtml", BottomBrackets);
        }

        // GET: Brakes
        public ActionResult Brakes()
        {
            ViewBag.Message = "Brakes";

            var brakes = ComponentsProcessor.LoadBrakes();

            List<VendorBikeAndComponentModel> Brakes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listBrakes = mapper.Map<List<VendorBikeAndComponentModel>>(brakes);

            foreach (VendorBikeAndComponentModel e in listBrakes)
            {
                Brakes.Add(e);
            }

            return View("Views/Components/Brakes.cshtml", Brakes);
        }

        // GET: Chains
        public ActionResult Chains()
        {
            ViewBag.Message = "Chains";

            var chains = ComponentsProcessor.LoadChains();

            List<VendorBikeAndComponentModel> Chains = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listChains = mapper.Map<List<VendorBikeAndComponentModel>>(chains);

            foreach (VendorBikeAndComponentModel e in listChains)
            {
                Chains.Add(e);
            }

            return View("Views/Components/Chains.cshtml", Chains);
        }

        // GET: Cranksets
        public ActionResult Cranksets()
        {
            ViewBag.Message = "Cranksets";

            var cranksets = ComponentsProcessor.LoadCranksets();

            List<VendorBikeAndComponentModel> Cranksets = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listCranksets = mapper.Map<List<VendorBikeAndComponentModel>>(cranksets);

            foreach (VendorBikeAndComponentModel e in listCranksets)
            {
                Cranksets.Add(e);
            }

            return View("Views/Components/Cranksets.cshtml", Cranksets);
        }

        // GET: Derailleurs
        public ActionResult Derailleurs()
        {
            ViewBag.Message = "Derailleurs";

            var derailleurs = ComponentsProcessor.LoadDerailleurs();

            List<VendorBikeAndComponentModel> Derailleurs = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listDerailleurs = mapper.Map<List<VendorBikeAndComponentModel>>(derailleurs);

            foreach (VendorBikeAndComponentModel e in listDerailleurs)
            {
                Derailleurs.Add(e);
            }

            return View("Views/Components/Derailleurs.cshtml", Derailleurs);
        }

        // GET: Forks
        public ActionResult Forks()
        {
            ViewBag.Message = "Forks";

            var forks = ComponentsProcessor.LoadForks();

            List<VendorBikeAndComponentModel> Forks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listForks = mapper.Map<List<VendorBikeAndComponentModel>>(forks);

            foreach (VendorBikeAndComponentModel e in listForks)
            {
                Forks.Add(e);
            }

            return View("Views/Components/Forks.cshtml", Forks);
        }

        // GET: Handlebars
        public ActionResult Handlebars()
        {
            ViewBag.Message = "Handlebars";

            var handlebars = ComponentsProcessor.LoadHandlebars();

            List<VendorBikeAndComponentModel> Handlebars = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listHandlebars = mapper.Map<List<VendorBikeAndComponentModel>>(handlebars);

            foreach (VendorBikeAndComponentModel e in listHandlebars)
            {
                Handlebars.Add(e);
            }

            return View("Views/Components/Handlebars.cshtml", Handlebars);
        }

        // GET: Headsets
        public ActionResult Headsets()
        {
            ViewBag.Message = "Headsets";

            var headsets = ComponentsProcessor.LoadHeadsets();

            List<VendorBikeAndComponentModel> Headsets = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listHeadsets = mapper.Map<List<VendorBikeAndComponentModel>>(headsets);

            foreach (VendorBikeAndComponentModel e in listHeadsets)
            {
                Headsets.Add(e);
            }

            return View("Views/Components/Headsets.cshtml", Headsets);
        }

        // GET: Mountain Frames
        public ActionResult MountainFrames()
        {
            ViewBag.Message = "Mountain Frames";

            var mountainFrames = ComponentsProcessor.LoadMountainFrames();

            List<VendorBikeAndComponentModel> MountainFrames = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listMountainFrames = mapper.Map<List<VendorBikeAndComponentModel>>(mountainFrames);

            foreach (VendorBikeAndComponentModel e in listMountainFrames)
            {
                MountainFrames.Add(e);
            }

            return View("Views/Components/MountainFrames.cshtml", MountainFrames);
        }

        // GET: Pedals
        public ActionResult Pedals()
        {
            ViewBag.Message = "Pedals";

            var pedals = ComponentsProcessor.LoadPedals();

            List<VendorBikeAndComponentModel> Pedals = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listPedals = mapper.Map<List<VendorBikeAndComponentModel>>(pedals);

            foreach (VendorBikeAndComponentModel e in listPedals)
            {
                Pedals.Add(e);
            }

            return View("Views/Components/Pedals.cshtml", Pedals);
        }

        // GET: Raw Materials
        public ActionResult RawMaterials()
        {
            ViewBag.Message = "Raw Materials";

            var rawMaterials = ComponentsProcessor.LoadRawMaterials();

            List<VendorBikeAndComponentModel> RawMaterials = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listRawMaterials = mapper.Map<List<VendorBikeAndComponentModel>>(rawMaterials);

            foreach (VendorBikeAndComponentModel e in listRawMaterials)
            {
                RawMaterials.Add(e);
            }

            return View("Views/Components/RawMaterials.cshtml", RawMaterials);
        }

        // GET: Road Frames
        public ActionResult RoadFrames()
        {
            ViewBag.Message = "Road Frames";

            var roadFrames = ComponentsProcessor.LoadRoadFrames();

            List<VendorBikeAndComponentModel> RoadFrames = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listRoadFrames = mapper.Map<List<VendorBikeAndComponentModel>>(roadFrames);

            foreach (VendorBikeAndComponentModel e in listRoadFrames)
            {
                RoadFrames.Add(e);
            }

            return View("Views/Components/RoadFrames.cshtml", RoadFrames);
        }

        // GET: Saddles
        public ActionResult Saddles()
        {
            ViewBag.Message = "Saddles";

            var saddles = ComponentsProcessor.LoadSaddles();

            List<VendorBikeAndComponentModel> Saddles = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listSaddles = mapper.Map<List<VendorBikeAndComponentModel>>(saddles);

            foreach (VendorBikeAndComponentModel e in listSaddles)
            {
                Saddles.Add(e);
            }

            return View("Views/Components/Saddles.cshtml", Saddles);
        }

        // GET: Touring Frames
        public ActionResult TouringFrames()
        {
            ViewBag.Message = "Touring Frames";

            var touringFrames = ComponentsProcessor.LoadTouringFrames();

            List<VendorBikeAndComponentModel> TouringFrames = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listTouringFrames = mapper.Map<List<VendorBikeAndComponentModel>>(touringFrames);

            foreach (VendorBikeAndComponentModel e in listTouringFrames)
            {
                TouringFrames.Add(e);
            }

            return View("Views/Components/TouringFrames.cshtml", TouringFrames);
        }

        // GET: Wheels
        public ActionResult Wheels()
        {
            ViewBag.Message = "Wheels";

            var wheels = ComponentsProcessor.LoadWheels();

            List<VendorBikeAndComponentModel> Wheels = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listWheels = mapper.Map<List<VendorBikeAndComponentModel>>(wheels);

            foreach (VendorBikeAndComponentModel e in listWheels)
            {
                Wheels.Add(e);
            }

            return View("Views/Components/Wheels.cshtml", Wheels);
        }
    }
}
