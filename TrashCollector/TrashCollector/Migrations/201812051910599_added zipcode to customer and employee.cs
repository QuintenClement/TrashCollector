namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedzipcodetocustomerandemployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "ZipCode");
            DropColumn("dbo.Customers", "ZipCode");
        }
    }
}
