using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    public class VendorAccessoriesController : Controller
    {
        [Authorize(Roles = "Administrator, Vendor")]
        public IActionResult Index()
        {
            return View();
        }

        // VendorAccessories Sub-Categories

        //GET: Vendor Bike Racks
        public ActionResult BikeRacks()
        {
            ViewBag.Message = "Bike Racks";

            var bikeRacks = AccessoriesProcessor.LoadBikeRacks();

            List<VendorAccessoriesModel> BikeRacks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listBikeRacks = mapper.Map<List<VendorAccessoriesModel>>(bikeRacks);

            foreach (VendorAccessoriesModel e in listBikeRacks)
            {
                BikeRacks.Add(e);
            }

            return View("Views/VendorAccessories/VendorBikeRacks.cshtml", BikeRacks);
        }

        // GET: Vendor Bike Stands
        public ActionResult BikeStands()
        {
            ViewBag.Message = "Bike Stands";

            var bikeStands = AccessoriesProcessor.LoadBikeStands();

            List<VendorAccessoriesModel> BikeStands = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listBikeStands = mapper.Map<List<VendorAccessoriesModel>>(bikeStands);

            foreach (VendorAccessoriesModel e in listBikeStands)
            {
                BikeStands.Add(e);
            }

            return View("Views/VendorAccessories/VendorBikeStands.cshtml", BikeStands);
        }

        // GET: Vendor Bottles And Cages
        public ActionResult BottlesAndCages()
        {
            ViewBag.Message = "Bottles And Cages";

            var bottlesAndCages = AccessoriesProcessor.LoadBottlesAndCages();

            List<VendorAccessoriesModel> BottlesAndCages = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listBottlesAndCages = mapper.Map<List<VendorAccessoriesModel>>(bottlesAndCages);

            foreach (VendorAccessoriesModel e in listBottlesAndCages)
            {
                BottlesAndCages.Add(e);
            }

            return View("Views/VendorAccessories/VendorBottlesAndCages.cshtml", BottlesAndCages);
        }

        // GET: Vendor Cleaners
        public ActionResult Cleaners()
        {
            ViewBag.Message = "Cleaners";

            var cleaners = AccessoriesProcessor.LoadCleaners();

            List<VendorAccessoriesModel> Cleaners = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listCleaners = mapper.Map<List<VendorAccessoriesModel>>(cleaners);

            foreach (VendorAccessoriesModel e in listCleaners)
            {
                Cleaners.Add(e);
            }

            return View("Views/VendorAccessories/VendorCleaners.cshtml", Cleaners);
        }

        // GET: Vendor Fenders
        public ActionResult Fenders()
        {
            ViewBag.Message = "Fenders";

            var fenders = AccessoriesProcessor.LoadFenders();

            List<VendorAccessoriesModel> Fenders = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listFenders = mapper.Map<List<VendorAccessoriesModel>>(fenders);

            foreach (VendorAccessoriesModel e in listFenders)
            {
                Fenders.Add(e);
            }

            return View("Views/VendorAccessories/VendorFenders.cshtml", Fenders);
        }

        // GET: Vendor Helmets
        public ActionResult Helmets()
        {
            ViewBag.Message = "Helmets";

            var helmets = AccessoriesProcessor.LoadHelmets();

            List<VendorAccessoriesModel> Helmets = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listHelmets = mapper.Map<List<VendorAccessoriesModel>>(helmets);

            foreach (VendorAccessoriesModel e in listHelmets)
            {
                Helmets.Add(e);
            }

            return View("Views/VendorAccessories/VendorHelmets.cshtml", Helmets);
        }

        // GET: Vendor Hydration Packs
        public ActionResult HydrationPacks()
        {
            ViewBag.Message = "HydrationPacks";

            var hydrationPacks = AccessoriesProcessor.LoadHydrationPacks();

            List<VendorAccessoriesModel> HydrationPacks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listHydrationPacks = mapper.Map<List<VendorAccessoriesModel>>(hydrationPacks);

            foreach (VendorAccessoriesModel e in listHydrationPacks)
            {
                HydrationPacks.Add(e);
            }

            return View("Views/VendorAccessories/VendorHydrationPacks.cshtml", HydrationPacks);
        }

        // GET: Vendor Lights
        public ActionResult Lights()
        {
            ViewBag.Message = "Lights";

            var lights = AccessoriesProcessor.LoadLights();

            List<VendorAccessoriesModel> Lights = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listLights = mapper.Map<List<VendorAccessoriesModel>>(lights);

            foreach (VendorAccessoriesModel e in listLights)
            {
                Lights.Add(e);
            }

            return View("Views/VendorAccessories/VendorLights.cshtml", Lights);
        }

        // GET: Vendor Locks
        public ActionResult Locks()
        {
            ViewBag.Message = "Locks";

            var locks = AccessoriesProcessor.LoadLocks();

            List<VendorAccessoriesModel> Locks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listLocks = mapper.Map<List<VendorAccessoriesModel>>(locks);

            foreach (VendorAccessoriesModel e in listLocks)
            {
                Locks.Add(e);
            }

            return View("Views/VendorAccessories/VendorLocks.cshtml", Locks);
        }

        // GET: Vendor Panniers
        public ActionResult Panniers()
        {
            ViewBag.Message = "Panniers";

            var panniers = AccessoriesProcessor.LoadPanniers();

            List<VendorAccessoriesModel> Panniers = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listPanniers = mapper.Map<List<VendorAccessoriesModel>>(panniers);

            foreach (VendorAccessoriesModel e in listPanniers)
            {
                Panniers.Add(e);
            }

            return View("Views/VendorAccessories/VendorPanniers.cshtml", Panniers);
        }

        // GET: Vendor Pumps
        public ActionResult Pumps()
        {
            ViewBag.Message = "Pumps";

            var pumps = AccessoriesProcessor.LoadPumps();

            List<VendorAccessoriesModel> Pumps = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listPumps = mapper.Map<List<VendorAccessoriesModel>>(pumps);

            foreach (VendorAccessoriesModel e in listPumps)
            {
                Pumps.Add(e);
            }

            return View("Views/VendorAccessories/VendorPumps.cshtml", Pumps);
        }

        // GET: Vendor Tires And Tubes
        public ActionResult TiresAndTubes()
        {
            ViewBag.Message = "Tires And Tubes";

            var tiresAndTubes = AccessoriesProcessor.LoadTiresAndTubes();

            List<VendorAccessoriesModel> TiresAndTubes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listTiresAndTubes = mapper.Map<List<VendorAccessoriesModel>>(tiresAndTubes);

            foreach (VendorAccessoriesModel e in listTiresAndTubes)
            {
                TiresAndTubes.Add(e);
            }

            return View("Views/VendorAccessories/VendorTiresAndTubes.cshtml", TiresAndTubes);
        }
    }
}
