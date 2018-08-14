namespace MVCWebApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCWebApplication.DataAccessLayer.SalesERPDAL>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVCWebApplication.DataAccessLayer.SalesERPDAL";
        }

        protected override void Seed(MVCWebApplication.DataAccessLayer.SalesERPDAL context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
