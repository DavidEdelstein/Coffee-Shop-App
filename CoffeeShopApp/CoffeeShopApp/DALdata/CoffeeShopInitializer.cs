using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CoffeeShopApp.DALdata
{
    public class CoffeeShopInitializer : System.Data.Entity.DropCreateDatabaseAlways<CoffeeShopContext>
    {
       
    }
}