

using MySql.Data.Entity;
using NandosoRestaurant.Models;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace NandosoRestaurant
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class NandosoDBContext : DbContext
    {
        //public System.Data.Entity.DbSet <NandosoRestaurant.Models.MySpecial> MySpecial { get; set; }
        public class MyConfiguration : DbMigrationsConfiguration<NandosoRestaurant.NandosoDBContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
            }

            protected override void Seed(NandosoRestaurant.NandosoDBContext context)
            {
                var specials = new List<MySpecial>
            {
                new MySpecial {
                    Id = 1,
                    Dishname= "Chicken",
                    Category = "Entry",
                    Price= 11
                },

                new MySpecial {
                    Id = 2,
                    Dishname= "Beef",
                    Category = "Mains",
                    Price= 42
                },

                new MySpecial {
                    Id = 3,
                    Dishname= "Beef",
                    Category = "Mains",
                    Price= 42
                },
            };

                specials.ForEach(s => context.specials.AddOrUpdate(p => p.Dishname, s));
                context.SaveChanges();
            }
        }

        public NandosoDBContext() : base("name=NandosoDBContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NandosoDBContext, MyConfiguration>());


        }

      //  public NandosoDBContext(DbConnection existingConnection, bool contextOwnsConnection)
      //: base(existingConnection, contextOwnsConnection)
      //  {

      //  }

        //To add specials to db
        public DbSet<MySpecial> specials { get; set; }

        public DbSet<MyFeedback> feedbacks { get; set; }

    }

   
}