namespace HackathonProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HackathonProject.Models;
    using HackathonProject.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<HackathonProject.DAL.HackathonDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HackathonProject.DAL.HackathonDBContext context)
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

            context.Buildings.AddOrUpdate(
                x => x.ID,
                new Building() { ID = 1, BuildingCode = "A" },
                new Building() { ID = 2, BuildingCode = "B" },
                new Building() { ID = 1, BuildingCode = "C" },
                new Building() { ID = 1, BuildingCode = "D" },
                new Building() { ID = 1, BuildingCode = "E" });



        }
    }
}
