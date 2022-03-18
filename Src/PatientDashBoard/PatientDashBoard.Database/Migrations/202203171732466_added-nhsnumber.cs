namespace PatientDashBoard.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednhsnumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patient", "NhsNumber", c => c.String());
            AddColumn("dbo.Patient", "EMail", c => c.String());
            DropColumn("dbo.Patient", "Emnail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patient", "Emnail", c => c.String());
            DropColumn("dbo.Patient", "EMail");
            DropColumn("dbo.Patient", "NhsNumber");
        }
    }
}
