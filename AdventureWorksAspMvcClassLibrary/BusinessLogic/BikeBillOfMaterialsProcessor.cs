using AdventureWorksAspMvcClassLibrary.DataAccess;
using AdventureWorksAspMvcClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.BusinessLogic
{
    public class BikeBillOfMaterialsProcessor
    {
        private static readonly SqlDataAccess db = new SqlDataAccess();

        //Database calls for Bike Bill Of Materials

        public static List<BikeBillOfMaterialsModel> LoadBikeBillOfMaterials(int id) =>
    db.LoadAllData<BikeBillOfMaterialsModel, dynamic>($"EXEC SP_GetBillOfMaterialsOnline @StartProductID = {id};", new { });
    }
}
