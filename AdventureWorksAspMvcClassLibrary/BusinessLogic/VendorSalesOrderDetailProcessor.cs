using AdventureWorksAspMvcClassLibrary.DataAccess;
using AdventureWorksAspMvcClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.BusinessLogic
{
    public class VendorSalesOrderDetailProcessor
    {
        private static readonly SqlDataAccess db = new SqlDataAccess();

        public static List<AccessoriesModel> LoadBikeRacks() =>
            db.LoadAllData<AccessoriesModel, dynamic>(@"SELECT * FROM v_AccessoriesProductCategory WHERE SubCategory = 'Bike Racks' ORDER BY ListPrice;", new { });
    }
}
