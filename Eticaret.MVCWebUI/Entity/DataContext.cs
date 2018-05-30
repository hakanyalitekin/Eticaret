using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Eticaret.MVCWebUI.Entity
{
    public class DataContext: DbContext
    {
        public DataContext():base("dataConnection")
        {
            Database.SetInitializer(new DataIntializer());
        }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Tablo isimlerindeki 's' çoğul takısını kaldırmak için.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler{ get; set; }
    }
}