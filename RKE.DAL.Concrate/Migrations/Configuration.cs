namespace RKE.DAL.Concrate.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RKE.DAL.Concrate.ContextOfDatabase.RKEContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(RKE.DAL.Concrate.ContextOfDatabase.RKEContext context)
        {
           
        }
    }
}
