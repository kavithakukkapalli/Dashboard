namespace PatientDashBoard.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdbsetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        AppointmentDateTime = c.DateTime(nullable: false),
                        ReasonForAppointment = c.String(),
                        Duration = c.Int(nullable: false),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Emnail = c.String(),
                        PhoneNumber = c.String(),
                        Status = c.String(),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        County = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Address");
            DropTable("dbo.Patient");
            DropTable("dbo.Appointments");
        }
    }
}
