namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RegionId = c.Int(nullable: false),
                        ListOfCountry_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ListOfCountries", t => t.ListOfCountry_Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId)
                .Index(t => t.ListOfCountry_Id);
            
            CreateTable(
                "dbo.ListOfCountries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TourId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TourTypeId = c.Int(nullable: false),
                        InfoId = c.Int(nullable: false),
                        ListOfCountry_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ListOfCountries", t => t.ListOfCountry_Id)
                .Index(t => t.ListOfCountry_Id);
            
            CreateTable(
                "dbo.TourInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Info = c.String(),
                        Tour_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tours", t => t.Tour_Id)
                .Index(t => t.Tour_Id);
            
            CreateTable(
                "dbo.TourTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Tour_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tours", t => t.Tour_Id)
                .Index(t => t.Tour_Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Countries", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.TourTypes", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.TourInfoes", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.Tours", "ListOfCountry_Id", "dbo.ListOfCountries");
            DropForeignKey("dbo.Countries", "ListOfCountry_Id", "dbo.ListOfCountries");
            DropIndex("dbo.TourTypes", new[] { "Tour_Id" });
            DropIndex("dbo.TourInfoes", new[] { "Tour_Id" });
            DropIndex("dbo.Tours", new[] { "ListOfCountry_Id" });
            DropIndex("dbo.Countries", new[] { "ListOfCountry_Id" });
            DropIndex("dbo.Countries", new[] { "RegionId" });
            DropTable("dbo.Regions");
            DropTable("dbo.TourTypes");
            DropTable("dbo.TourInfoes");
            DropTable("dbo.Tours");
            DropTable("dbo.ListOfCountries");
            DropTable("dbo.Countries");
        }
    }
}
