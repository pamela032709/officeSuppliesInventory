namespace HackathonProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createInventoryTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BuildingCode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        categoryID = c.Int(nullable: false),
                        SKU = c.Int(nullable: false),
                        itemDescription = c.String(),
                        value = c.Double(nullable: false),
                        unitsPerPackage = c.Int(nullable: false),
                        unitRate = c.Double(nullable: false),
                        minimumInventory = c.Int(nullable: false),
                        maximumInventory = c.Int(nullable: false),
                        quantityTrigger = c.Int(nullable: false),
                        costTrigger = c.Double(nullable: false),
                        buildingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inventories");
            DropTable("dbo.Categories");
            DropTable("dbo.Buildings");
        }
    }
}
