using System.Data.Entity.Migrations;

namespace PatientDashBoard.Database.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PatientDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PatientDBContext context)
        {

            

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
