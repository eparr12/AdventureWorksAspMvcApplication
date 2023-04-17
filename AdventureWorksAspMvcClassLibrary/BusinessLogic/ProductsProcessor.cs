using AdventureWorksAspMvcClassLibrary.DataAccess;
using AdventureWorksAspMvcClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.BusinessLogic
{
    public static class ProductsProcessor
    {
        private static readonly SqlDataAccess db = new SqlDataAccess();
   
        public static List<AccessoriesModel> LoadAccessories() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory ORDER BY SubCategory,ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadBikes() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_BikesProductCategory ORDER BY SubCategory,ListPrice;", new { });

        public static List<ClothingModel> LoadClothing() =>
            db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory ORDER BY SubCategory,ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadComponents() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory ORDER BY SubCategory,ListPrice;", new { });
    }
}
