using AdventureWorksAspMvcClassLibrary.DataAccess;
using AdventureWorksAspMvcClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.BusinessLogic
{
    public class BikesProcessor
    {
        private static readonly SqlDataAccess db = new SqlDataAccess();

        //Database calls for Bikes category

        public static List<BikeAndComponentModel> LoadMountainBikes() =>
    db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_BikesProductCategory WHERE SubCategory = 'Mountain Bikes' ORDER BY ListPrice;", new { });

        public static List<BikeAndComponentModel> LoadRoadBikes() =>
    db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_BikesProductCategory WHERE SubCategory = 'Road Bikes' ORDER BY ListPrice;", new { });
 
        public static List<BikeAndComponentModel> LoadTouringBikes() =>
    db.LoadAllData<BikeAndComponentModel, dynamic>(@"SELECT * FROM v_BikesProductCategory WHERE SubCategory = 'Touring Bikes' ORDER BY ListPrice;", new { });
    }
}
