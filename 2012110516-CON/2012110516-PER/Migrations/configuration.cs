namespace _2012110516_PER.Migrations
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

internal sealed class Configuration : DbMigrationsConfiguration<_2012110516_PER.TelefonicaDbContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = false;
    }
        protected override void Seed(_2012110516_PER.TelefonicaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
