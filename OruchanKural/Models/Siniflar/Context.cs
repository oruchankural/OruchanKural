using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace OruchanKural.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}