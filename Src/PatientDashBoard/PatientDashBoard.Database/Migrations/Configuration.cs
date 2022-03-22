using System;
using System.Data.Entity.Migrations;
using System.Linq;
using PatientDashBoard.Models;

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

            if (!context.Patient.Any())
            {
                Patient c = new Patient
                {
                    PatientId = 1,
                    FirstName = "Kavitha",
                    LastName = "Kukkapalli",
                    EMail = "test@gmail.com",
                    Deleted = false,
                    Dob = DateTime.Parse("12/05/1990"),
                    NhsNumber = "123454667",
                    PhoneNumber = "075065646545",
                    Status = "Active"
                };
                var b = new Patient
                {
                    PatientId = 1,
                    FirstName = "Dean",
                    LastName = "Garetty",
                    EMail = "dean@gmail.com",
                    Deleted = false,
                    Dob = DateTime.Parse("12/05/1980"),
                    NhsNumber = "1234343242347",
                    PhoneNumber = "075063453455",
                    Status = "Active"
                };
                var a = new Patient
                {
                    PatientId = 1,
                    FirstName = "Stephen",
                    LastName = "Frackelton",
                    EMail = "stephen@gmail.com",
                    Deleted = false,
                    Dob = DateTime.Parse("12/05/1980"),
                    NhsNumber = "5764564",
                    PhoneNumber = "0755645645",
                    Status = "Active"
                };

                var cAddress = new Address
                {
                    PatientId = 1,
                    AddressLine1 = "12",
                    AddressLine2 = "Some street",
                    PostCode = "L11 1AP",
                    City = "Liverpool",
                    County = "Mersyside"
                };

                context.Patient.Add(a);
                context.Patient.Add(b);
                context.Patient.Add(c);

                context.PatientAddress.Add(cAddress);
                context.SaveChanges();
            }
        }
    }
}
