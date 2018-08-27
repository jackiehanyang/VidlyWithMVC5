namespace VidlyWithMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropBirthdayFromCustomers : DbMigration
    {
        public override void Up()
        {
            DropColumn("Customers", "Birthday");
        }
        
        public override void Down()
        {
        }
    }
}
