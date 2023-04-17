using AdventureWorksAspMvcClassLibrary.BusinessLogic;
using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdventureWorksAspMvcUI.Controllers
{
    [Authorize(Roles = "Administrator, Vendor")]
    public class VendorProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Product Categories

        // GET: Vendor Accessories
        public ActionResult Accessories()
        {
            ViewBag.Message = "Accessories";

            var accessories = ProductsProcessor.LoadAccessories();

            List<VendorAccessoriesModel> Accessories = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.AccessoriesModel, VendorAccessoriesModel>());
            var mapper = new Mapper(config);
            var listAccessories = mapper.Map<List<VendorAccessoriesModel>>(accessories);

            foreach (VendorAccessoriesModel e in listAccessories)
            {
                Accessories.Add(e);
            }

            return View("Views/VendorProducts/VendorAccessories.cshtml", Accessories);
        }

        // GET: Vendor Bikes
        public ActionResult Bikes()
        {
            ViewBag.Message = "Bikes And Components";

            var bikes = ProductsProcessor.LoadBikes();

            List<VendorBikeAndComponentModel> Bikes = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listBikes = mapper.Map<List<VendorBikeAndComponentModel>>(bikes);

            foreach (VendorBikeAndComponentModel e in listBikes)
            {
                Bikes.Add(e);
            }

            return View("Views/VendorProducts/VendorBikes.cshtml", Bikes);
        }

        // GET: Vendor Clothing
        public ActionResult Clothing()
        {
            ViewBag.Message = "Clothing";

            var clothing = ProductsProcessor.LoadClothing();

            List<VendorClothingModel> Clothing = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.ClothingModel, VendorClothingModel>());
            var mapper = new Mapper(config);
            var listClothing = mapper.Map<List<VendorClothingModel>>(clothing);

            foreach (VendorClothingModel e in listClothing)
            {
                Clothing.Add(e);
            }

            return View("Views/VendorProducts/VendorClothing.cshtml", Clothing);
        }

        public ActionResult Components()
        {
            ViewBag.Message = "Components";

            var components = ProductsProcessor.LoadComponents();

            List<VendorBikeAndComponentModel> Components = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listComponents = mapper.Map<List<VendorBikeAndComponentModel>>(components);

            foreach (VendorBikeAndComponentModel e in listComponents)
            {
                Components.Add(e);
            }

            var bikes = ProductsProcessor.LoadBikes();

            List<VendorBikeAndComponentModel> Bikes = new();

            var configure = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var newmapper = new Mapper(configure);
            var listBikes = newmapper.Map<List<VendorBikeAndComponentModel>>(bikes);

            var model = new BikeSelectListModel();

            model.BikesSelectList = new List<SelectListItem>();

            foreach (VendorBikeAndComponentModel e in listBikes)
            {
                model.BikesSelectList.Add(new SelectListItem { Text = e.Name, Value = e.Id.ToString() });
            }

            ViewBag.Components = MyComponents();

            ViewBag.selectList = model;

            return View("Views/VendorProducts/Components.cshtml",model);
        }

        public List<VendorBikeAndComponentModel> MyComponents()
        {
            var components = ProductsProcessor.LoadComponents();

            List<VendorBikeAndComponentModel> Components = new();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdventureWorksAspMvcClassLibrary.Models.BikeAndComponentModel, VendorBikeAndComponentModel>());
            var mapper = new Mapper(config);
            var listComponents = mapper.Map<List<VendorBikeAndComponentModel>>(components);

            foreach (VendorBikeAndComponentModel e in listComponents)
            {
                Components.Add(e);
            }

            return Components;
        }
    }
}
