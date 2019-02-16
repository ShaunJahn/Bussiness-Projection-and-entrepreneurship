using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Business_Plan.Models;

namespace Business_Plan.DbContext
{
    public class DbContextUser : IdentityDbContext<IdentityUser>
    {
        public DbContextUser(DbContextOptions<DbContextUser> options) : base(options)
        {
            Database.Migrate();
        }


        public DbSet<ProductDto> ProductItem { get; set; }
        public DbSet<FOBDto> FOBs { get; set; }
        public DbSet<StockDto> Stocks { get; set; }
        public DbSet<ProdutBasicsUnitCostsDto> ProdutBasicsUnitCosts { get; set; }

    }
}



