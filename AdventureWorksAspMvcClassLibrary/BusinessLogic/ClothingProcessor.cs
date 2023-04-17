using AdventureWorksAspMvcClassLibrary.DataAccess;
using AdventureWorksAspMvcClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.BusinessLogic
{
    public class ClothingProcessor
    {
        private static readonly SqlDataAccess db = new SqlDataAccess();

        //Database calls for Clothing category

        public static List<ClothingModel> LoadBibShorts() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Bib Shorts' ORDER BY ListPrice;", new { });

        public static List<ClothingModel> LoadCaps() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Caps' ORDER BY ListPrice;", new { });

        public static List<ClothingModel> LoadGloves() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Gloves' ORDER BY ListPrice;", new { });

        public static List<ClothingModel> LoadJerseys() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Jerseys' ORDER BY ListPrice;", new { });

        public static List<ClothingModel> LoadShorts() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Shorts' ORDER BY ListPrice;", new { });

        public static List<ClothingModel> LoadSocks() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Socks' ORDER BY ListPrice;", new { });

        public static List<ClothingModel> LoadTights() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Tights' ORDER BY ListPrice;", new { });

        public static List<ClothingModel> LoadVests() =>
    db.LoadAllData<ClothingModel, dynamic>(@"SELECT * FROM v_ClothingProductCategory WHERE SubCategory = 'Vests' ORDER BY ListPrice;", new { });
    }
}
