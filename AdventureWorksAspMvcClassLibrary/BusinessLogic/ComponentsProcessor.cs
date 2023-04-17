using AdventureWorksAspMvcClassLibrary.DataAccess;
using AdventureWorksAspMvcClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.BusinessLogic
{
    public class ComponentsProcessor
    {
        private static readonly SqlDataAccess db = new SqlDataAccess();

        //Database calls for components category

        public static List<BikeAndComponentModel> LoadBottomBrackets() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Bottom Brackets' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadBrakes() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Brakes' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadChains() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Chains' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadCranksets() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Cranksets' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadDerailleurs() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Derailleurs' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadForks() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Forks' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadHandlebars() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Handlebars' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadHeadsets() =>
            db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Headsets' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadMountainFrames() =>
        db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Mountain Frames' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadPedals() =>
        db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Pedals' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadRawMaterials() =>
        db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Raw Materials' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadRoadFrames() =>
        db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Road Frames' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadSaddles() =>
       db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Saddles' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadTouringFrames() =>
       db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Touring Frames' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadWheels() =>
       db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_ComponentsProductCategory WHERE SubCategory = 'Wheels' ORDER BY ListPrice;", new { });
    }
}
