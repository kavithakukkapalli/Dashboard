using PatientDashBoard.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PatientDashBoard.Database
{
    public class PatientDBContext : DbContext
    {
        public PatientDBContext() : base("name=PatientDb")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Address> PatientAddress { get; set; }
        public DbSet<Appointments> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
