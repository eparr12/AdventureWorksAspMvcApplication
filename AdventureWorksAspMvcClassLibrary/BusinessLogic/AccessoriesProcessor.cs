using AdventureWorksAspMvcClassLibrary.DataAccess;
using AdventureWorksAspMvcClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.BusinessLogic
{
    public class AccessoriesProcessor
    {
        private static readonly SqlDataAccess db = new SqlDataAccess();

    //Database calls for Accessories category
        public static List<AccessoriesModel> LoadBikeRacks() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Bike Racks' ORDER BY ListPrice;", new { });

        public static List<AccessoriesModel> LoadBikeStands() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Bike Stands' ORDER BY ListPrice;", new { });
  
        public static List<AccessoriesModel> LoadBottlesAndCages() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Bottles and Cages' ORDER BY ListPrice;", new { });

        public static List<AccessoriesModel> LoadCleaners() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Cleaners' ORDER BY ListPrice;", new { });
 
        public static List<AccessoriesModel> LoadFenders() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Fenders' ORDER BY ListPrice;", new { });
  
        public static List<AccessoriesModel> LoadHelmets() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Helmets' ORDER BY ListPrice;", new { });

        public static List<AccessoriesModel> LoadHydrationPacks() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Hydration Packs' ORDER BY ListPrice;", new { });
 
        public static List<AccessoriesModel> LoadLights() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Lights' ORDER BY ListPrice;", new { });

        public static List<AccessoriesModel> LoadLocks() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Locks' ORDER BY ListPrice;", new { });

        public static List<AccessoriesModel> LoadPanniers() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Panniers' ORDER BY ListPrice;", new { });

        public static List<AccessoriesModel> LoadPumps() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Pumps' ORDER BY ListPrice;", new { });
  
        public static List<AccessoriesModel> LoadTiresAndTubes() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Tires and Tubes' ORDER BY ListPrice;", new { });
    }
}
