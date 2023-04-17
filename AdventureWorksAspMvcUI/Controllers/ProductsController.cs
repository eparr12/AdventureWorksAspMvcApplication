using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdventureWorksAspMvcClassLibrary;
using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using AdventureWorksAspMvcClassLibrary.Models;
using AccessoriesModel = AdventureWorksAspMvcUI.Models.AccessoriesModel;
using System.Security.Permissions;
using BikeAndComponentModel = AdventureWorksAspMvcUI.Models.BikeAndComponentModel;
using ClothingModel = AdventureWorksAspMvcUI.Models.ClothingModel;

namespace AdventureWorksAspMvcUI.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public ActionResult Index()
        {
            return View();
        }

    // Product Categories

        // GET: Accessories
        public ActionResult Accessories()
        {
            ViewBag.Message = "Accessories";

            var accessories = ProductsProcessor.LoadAccessories();

            List<AccessoriesModel> Accessories = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, AccessoriesModel>());
            var mapper = new Mapper(config);
            var listAccessories = mapper.Map<List<AccessoriesModel>>(accessories);

            foreach (AccessoriesModel e in listAccessories)
            {
                Accessories.Add(e);
            }

            return View(Accessories);
        }

        // GET: Bikes
        public ActionResult Bikes()
        {
            ViewBag.Message = "Bikes And Components";

            var accessories = ProductsProcessor.LoadBikes();

            List<BikeAndComponentModel> Bikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, BikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listBikes = mapper.Map<List<BikeAndComponentModel>>(accessories);

            foreach (BikeAndComponentModel e in listBikes)
            {
                Bikes.Add(e);
            }

            return View(Bikes);
        }

        // GET: Clothing
        public ActionResult Clothing()
        {
            ViewBag.Message = "Clothing";

            var clothing = ProductsProcessor.LoadClothing();

            List<ClothingModel> Clothing = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, ClothingModel>());
            var mapper = new Mapper(config);
            var listClothing = mapper.Map<List<ClothingModel>>(clothing);

            foreach (ClothingModel e in listClothing)
            {
                Clothing.Add(e);
            }

            return View(Clothing);
        }
    }
}
