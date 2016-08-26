using System.Collections.Generic;
//using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using NLayerApp.DAL.Entities;

namespace NLayerApp.DAL.EF
{
    public class HotelContext :DbContext
    {
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Order> Orders { get; set; }

        //static DataContext()
        //{
        //    Database.SetInitializer<DataContext>(new StoreDbInitializer());
        //}
        public HotelContext(string connectionString)
            : base(connectionString)
        {
        }
    }
    
    //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    //{
    //    protected override void Seed(DataContext db)
    //    {
    //        db.Numbers.Add(new Number { Name = "Nokia Lumia 630", Company = "Nokia", Price = 220 });
           
    //        db.SaveChanges();
    //    }
    //}
}
