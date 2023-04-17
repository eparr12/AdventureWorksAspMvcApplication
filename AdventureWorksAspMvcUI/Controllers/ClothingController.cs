using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAspMvcUI.Controllers
{
    public class ClothingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Clothing Sub-Categories

        // GET: Bib-Shorts
        public ActionResult BibShorts()
        {
            ViewBag.Message = "Bib-Shorts";

            var bibShorts = ClothingProcessor.LoadBibShorts();

            List<ClothingModel> BibShorts = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listBibShorts = mapper.Map<List<ClothingModel>>(bibShorts);

            foreach (ClothingModel e in listBibShorts)
            {
                BibShorts.Add(e);
            }

            return View("Views/Clothing/BibShorts.cshtml", BibShorts);
        }

        // GET: Caps
        public ActionResult Caps()
        {
            ViewBag.Message = "Caps";

            var caps = ClothingProcessor.LoadCaps();

            List<ClothingModel> Caps = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listCaps = mapper.Map<List<ClothingModel>>(caps);

            foreach (ClothingModel e in listCaps)
            {
                Caps.Add(e);
            }

            return View("Views/Clothing/Caps.cshtml", Caps);
        }

        // GET: Gloves
        public ActionResult Gloves()
        {
            ViewBag.Message = "Gloves";

            var gloves = ClothingProcessor.LoadGloves();

            List<ClothingModel> Gloves = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listGloves = mapper.Map<List<ClothingModel>>(gloves);

            foreach (ClothingModel e in listGloves)
            {
                Gloves.Add(e);
            }

            return View("Views/Clothing/Gloves.cshtml", Gloves);
        }

        // GET: Jerseys
        public ActionResult Jerseys()
        {
            ViewBag.Message = "Jerseys";

            var jerseys = ClothingProcessor.LoadJerseys();

            List<ClothingModel> Jerseys = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listJerseys = mapper.Map<List<ClothingModel>>(jerseys);

            foreach (ClothingModel e in listJerseys)
            {
                Jerseys.Add(e);
            }

            return View("Views/Clothing/Jerseys.cshtml", Jerseys);
        }

        // GET: Shorts
        public ActionResult Shorts()
        {
            ViewBag.Message = "Shorts";

            var shorts = ClothingProcessor.LoadShorts();

            List<ClothingModel> Shorts = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listShorts = mapper.Map<List<ClothingModel>>(shorts);

            foreach (ClothingModel e in listShorts)
            {
                Shorts.Add(e);
            }

            return View("Views/Clothing/Shorts.cshtml", Shorts);
        }

        // GET: Socks
        public ActionResult Socks()
        {
            ViewBag.Message = "Socks";

            var socks = ClothingProcessor.LoadSocks();

            List<ClothingModel> Socks = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listSocks = mapper.Map<List<ClothingModel>>(socks);

            foreach (ClothingModel e in listSocks)
            {
                Socks.Add(e);
            }

            return View("Views/Clothing/Socks.cshtml", Socks);
        }

        // GET: Tights
        public ActionResult Tights()
        {
            ViewBag.Message = "Tights";

            var tights = ClothingProcessor.LoadTights();

            List<ClothingModel> Tights = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listTights = mapper.Map<List<ClothingModel>>(tights);

            foreach (ClothingModel e in listTights)
            {
                Tights.Add(e);
            }

            return View("Views/Clothing/Tights.cshtml", Tights);
        }

        // GET: Vests
        public ActionResult Vests()
        {
            ViewBag.Message = "Vests";

            var vests = ClothingProcessor.LoadVests();

            List<ClothingModel> Vests = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listVests = mapper.Map<List<ClothingModel>>(vests);

            foreach (ClothingModel e in listVests)
            {
                Vests.Add(e);
            }

            return View("Views/Clothing/Vests.cshtml", Vests);
        }
    }
}
