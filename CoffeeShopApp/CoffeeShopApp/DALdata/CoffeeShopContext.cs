using CoffeeShopApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CoffeeShopApp.DALdata
{
   
        public class CoffeeShopContext : DbContext
        {
            public CoffeeShopContext() : base("CoffeeContext")
            {

            }

            public DbSet<NewUser> NewUsers { get; set; }
            

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
   
}