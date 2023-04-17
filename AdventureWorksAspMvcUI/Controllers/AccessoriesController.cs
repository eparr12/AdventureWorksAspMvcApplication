using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    //TODO figure out how to add all items in bill of materials to cart
    //TODO style everything in Home view folder
    public class AccessoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Accessories Sub-Categories

        // GET: BikeRacks
        public ActionResult BikeRacks()
        {
            ViewBag.Message = "Bike Racks";

            var bikeRacks = AccessoriesProcessor.LoadBikeRacks();

            List<AccessoriesModel> BikeRacks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listBikeRacks = mapper.Map<List<AccessoriesModel>>(bikeRacks);

            foreach (AccessoriesModel e in listBikeRacks)
            {
                BikeRacks.Add(e);
            }



            return View("Views/Accessories/BikeRacks.cshtml", BikeRacks);
        }

        // GET: BikeStands
        public ActionResult BikeStands()
        {
            ViewBag.Message = "Bike Stands";

            var bikeStands = AccessoriesProcessor.LoadBikeStands();

            List<AccessoriesModel> BikeStands = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listBikeStands = mapper.Map<List<AccessoriesModel>>(bikeStands);

            foreach (AccessoriesModel e in listBikeStands)
            {
                BikeStands.Add(e);
            }

            return View("Views/Accessories/BikeStands.cshtml", BikeStands);
        }

        // GET: Bottles And Cages
        public ActionResult BottlesAndCages()
        {
            ViewBag.Message = "Bottles And Cages";

            var bottlesAndCages = AccessoriesProcessor.LoadBottlesAndCages();

            List<AccessoriesModel> BottlesAndCages = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listBottlesAndCages = mapper.Map<List<AccessoriesModel>>(bottlesAndCages);

            foreach (AccessoriesModel e in listBottlesAndCages)
            {
                BottlesAndCages.Add(e);
            }

            return View("Views/Accessories/BottlesAndCages.cshtml", BottlesAndCages);
        }

        // GET: Cleaners
        public ActionResult Cleaners()
        {
            ViewBag.Message = "Cleaners";

            var cleaners = AccessoriesProcessor.LoadCleaners();

            List<AccessoriesModel> Cleaners = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listCleaners = mapper.Map<List<AccessoriesModel>>(cleaners);

            foreach (AccessoriesModel e in listCleaners)
            {
                Cleaners.Add(e);
            }

            return View("Views/Accessories/Cleaners.cshtml", Cleaners);
        }

        // GET: Fenders
        public ActionResult Fenders()
        {
            ViewBag.Message = "Fenders";

            var fenders = AccessoriesProcessor.LoadFenders();

            List<AccessoriesModel> Fenders = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listFenders = mapper.Map<List<AccessoriesModel>>(fenders);

            foreach (AccessoriesModel e in listFenders)
            {
                Fenders.Add(e);
            }

            return View("Views/Accessories/Fenders.cshtml", Fenders);
        }

        // GET: Helmets
        public ActionResult Helmets()
        {
            ViewBag.Message = "Helmets";

            var helmets = AccessoriesProcessor.LoadHelmets();

            List<AccessoriesModel> Helmets = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listHelmets = mapper.Map<List<AccessoriesModel>>(helmets);

            foreach (AccessoriesModel e in listHelmets)
            {
                Helmets.Add(e);
            }

            return View("Views/Accessories/Helmets.cshtml", Helmets);
        }

        // GET: Hydration Packs
        public ActionResult HydrationPacks()
        {
            ViewBag.Message = "HydrationPacks";

            var hydrationPacks = AccessoriesProcessor.LoadHydrationPacks();

            List<AccessoriesModel> HydrationPacks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listHydrationPacks = mapper.Map<List<AccessoriesModel>>(hydrationPacks);

            foreach (AccessoriesModel e in listHydrationPacks)
            {
                HydrationPacks.Add(e);
            }

            return View("Views/Accessories/HydrationPacks.cshtml", HydrationPacks);
        }

        // GET: Lights
        public ActionResult Lights()
        {
            ViewBag.Message = "Lights";

            var lights = AccessoriesProcessor.LoadLights();

            List<AccessoriesModel> Lights = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listLights = mapper.Map<List<AccessoriesModel>>(lights);

            foreach (AccessoriesModel e in listLights)
            {
                Lights.Add(e);
            }

            return View("Views/Accessories/Lights.cshtml", Lights);
        }

        // GET: Locks
        public ActionResult Locks()
        {
            ViewBag.Message = "Locks";

            var locks = AccessoriesProcessor.LoadLocks();

            List<AccessoriesModel> Locks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listLocks = mapper.Map<List<AccessoriesModel>>(locks);

            foreach (AccessoriesModel e in listLocks)
            {
                Locks.Add(e);
            }

            return View("Views/Accessories/Locks.cshtml", Locks);
        }

        // GET: Panniers
        public ActionResult Panniers()
        {
            ViewBag.Message = "Panniers";

            var panniers = AccessoriesProcessor.LoadPanniers();

            List<AccessoriesModel> Panniers = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listPanniers = mapper.Map<List<AccessoriesModel>>(panniers);

            foreach (AccessoriesModel e in listPanniers)
            {
                Panniers.Add(e);
            }

            return View("Views/Accessories/Panniers.cshtml", Panniers);
        }

        // GET: Pumps
        public ActionResult Pumps()
        {
            ViewBag.Message = "Pumps";

            var pumps = AccessoriesProcessor.LoadPumps();

            List<AccessoriesModel> Pumps = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listPumps = mapper.Map<List<AccessoriesModel>>(pumps);

            foreach (AccessoriesModel e in listPumps)
            {
                Pumps.Add(e);
            }

            return View("Views/Accessories/Pumps.cshtml", Pumps);
        }

        // GET: Tires And Tubes
        public ActionResult TiresAndTubes()
        {
            ViewBag.Message = "Tires And Tubes";

            var tiresAndTubes = AccessoriesProcessor.LoadTiresAndTubes();

            List<AccessoriesModel> TiresAndTubes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listTiresAndTubes = mapper.Map<List<AccessoriesModel>>(tiresAndTubes);

            foreach (AccessoriesModel e in listTiresAndTubes)
            {
                TiresAndTubes.Add(e);
            }

            return View("Views/Accessories/TiresAndTubes.cshtml", TiresAndTubes);
        }
    }
}
