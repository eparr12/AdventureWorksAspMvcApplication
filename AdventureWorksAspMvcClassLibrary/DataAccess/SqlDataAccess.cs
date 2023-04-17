using AdventureWorksAspMvcClassLibrary.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksAspMvcClassLibrary.DataAccess
{
    public class SqlDataAccess
    {
        public static string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            return builder.Build().GetConnectionString("AdventureWorks2014");
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public List<T> LoadAllData<T, U>(string sql, U parameters)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql, parameters).ToList();
            }
        }

        public static VendorSalesOrderModel VendorSalesOrder(VendorSalesOrderModel model)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@MiddleName", model.MiddleName);
                p.Add("@LastName", model.LastName);
                p.Add("@ShipMethodID", model.ShipMethod);
                p.Add("@Freight", model.Freight);
                p.Add("@SalesOrderID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                cnn.Execute("SP_AddOnlineVendorSalesOrder", p,commandType:CommandType.StoredProcedure);

                model.SalesOrderID = p.Get<int>("@SalesOrderID");

                return model;
            }
        }

        public static SalesOrderDetailModel SalesOrderDetail(SalesOrderDetailModel model)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@SalesOrderID", model.SalesOrderID);
                p.Add("@OrderQty", model.OrderQty);
                p.Add("@ProductID", model.ProductID);
                p.Add("@UnitPrice", model.UnitPrice);

                cnn.Execute("SP_AddOnlineVendorSalesOrderDetail", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }

        public static SalesOrderModel SalesOrder(SalesOrderModel model)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Suffix", model.Suffix);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@Email", model.Email);
                p.Add("@AddressLine1", model.AddressLine1);
                p.Add("@City", model.City);
                p.Add("@State", model.State);
                p.Add("@PostalCode", model.PostalCode);
                p.Add("@ShipMethodID", model.ShipMethod);
                p.Add("@Freight", model.Freight);
                p.Add("@SalesOrderID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                cnn.Execute("SP_AddOnlineSalesOrder", p, commandType: CommandType.StoredProcedure);

                model.SalesOrderID = p.Get<int>("@SalesOrderID");

                return model;
            }
        }
    }
}
