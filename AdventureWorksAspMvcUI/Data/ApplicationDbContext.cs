using AdventureWorksAspMvcUI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksAspMvcUI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AdventureWorksAspMvcUI.Models.AccessoriesModel> AccessoriesModel { get; set; }
        public DbSet<AdventureWorksAspMvcUI.Models.BikeAndComponentModel> BikeAndComponentModel { get; set; }
        public DbSet<AdventureWorksAspMvcUI.Models.ClothingModel> ClothingModel { get; set; }
        public DbSet<AdventureWorksAspMvcUI.Models.VendorBikeAndComponentModel> VendorBikeAndComponentModel { get; set; }
        public DbSet<AdventureWorksAspMvcUI.Models.BikeBillOfMaterialsModel> BikeBillOfMaterialsModel { get; set; }
        public DbSet<AdventureWorksAspMvcUI.Models.ShoppingCartModel> ShoppingCartModel { get; set; }
    }
}