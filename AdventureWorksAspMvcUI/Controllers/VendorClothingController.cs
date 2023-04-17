using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    [Authorize(Roles = "Administrator, Vendor")]
    public class VendorClothingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //VendorClothing Sub-Categories

        // GET: Vendor Bib-Shorts
        public ActionResult BibShorts()
        {
            ViewBag.Message = "Bib-Shorts";

            var bibShorts = ClothingProcessor.LoadBibShorts();

            List<VendorClothingModel> BibShorts = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listBibShorts = mapper.Map<List<VendorClothingModel>>(bibShorts);

            foreach (VendorClothingModel e in listBibShorts)
            {
                BibShorts.Add(e);
            }

            return View("Views/VendorClothing/VendorBibShorts.cshtml", BibShorts);
        }

        // GET: Vendor Caps
        public ActionResult Caps()
        {
            ViewBag.Message = "Caps";

            var caps = ClothingProcessor.LoadCaps();

            List<VendorClothingModel> Caps = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listCaps = mapper.Map<List<VendorClothingModel>>(caps);

            foreach (VendorClothingModel e in listCaps)
            {
                Caps.Add(e);
            }

            return View("Views/VendorClothing/VendorCaps.cshtml", Caps);
        }

        // GET: Vendor Gloves
        public ActionResult Gloves()
        {
            ViewBag.Message = "Gloves";

            var gloves = ClothingProcessor.LoadGloves();

            List<VendorClothingModel> Gloves = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listGloves = mapper.Map<List<VendorClothingModel>>(gloves);

            foreach (VendorClothingModel e in listGloves)
            {
                Gloves.Add(e);
            }

            return View("Views/VendorClothing/VendorGloves.cshtml", Gloves);
        }

        // GET: Vendor Jerseys
        public ActionResult Jerseys()
        {
            ViewBag.Message = "Jerseys";

            var jerseys = ClothingProcessor.LoadJerseys();

            List<VendorClothingModel> Jerseys = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listJerseys = mapper.Map<List<VendorClothingModel>>(jerseys);

            foreach (VendorClothingModel e in listJerseys)
            {
                Jerseys.Add(e);
            }

            return View("Views/VendorClothing/VendorJerseys.cshtml", Jerseys);
        }

        // GET: Vendor Shorts
        public ActionResult Shorts()
        {
            ViewBag.Message = "Shorts";

            var shorts = ClothingProcessor.LoadShorts();

            List<VendorClothingModel> Shorts = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listShorts = mapper.Map<List<VendorClothingModel>>(shorts);

            foreach (VendorClothingModel e in listShorts)
            {
                Shorts.Add(e);
            }

            return View("Views/VendorClothing/VendorShorts.cshtml", Shorts);
        }

        // GET: Vendor Socks
        public ActionResult Socks()
        {
            ViewBag.Message = "Socks";

            var socks = ClothingProcessor.LoadSocks();

            List<VendorClothingModel> Socks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listSocks = mapper.Map<List<VendorClothingModel>>(socks);

            foreach (VendorClothingModel e in listSocks)
            {
                Socks.Add(e);
            }

            return View("Views/VendorClothing/VendorSocks.cshtml", Socks);
        }

        // GET: Vendor Tights
        public ActionResult Tights()
        {
            ViewBag.Message = "Tights";

            var tights = ClothingProcessor.LoadTights();

            List<VendorClothingModel> Tights = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listTights = mapper.Map<List<VendorClothingModel>>(tights);

            foreach (VendorClothingModel e in listTights)
            {
                Tights.Add(e);
            }

            return View("Views/VendorClothing/VendorTights.cshtml", Tights);
        }

        // GET: Vendor Vests
        public ActionResult Vests()
        {
            ViewBag.Message = "Vests";

            var vests = ClothingProcessor.LoadVests();

            List<VendorClothingModel> Vests = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listVests = mapper.Map<List<VendorClothingModel>>(vests);

            foreach (VendorClothingModel e in listVests)
            {
                Vests.Add(e);
            }

            return View("Views/VendorClothing/VendorVests.cshtml", Vests);
        }
    }
}
