namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Pesel = c.String(),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cost = c.Int(nullable: false),
                        Since = c.DateTime(nullable: false),
                        Till = c.DateTime(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Client_Id = c.Int(),
                        Vehicle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        PricePerHour = c.Int(nullable: false),
                        FuelConsumption = c.Double(nullable: false),
                        DriversLicense = c.Int(nullable: false),
                        Name = c.String(),
                        Color = c.String(),
                        Vmax = c.Int(nullable: false),
                        TrunkCapacity = c.Int(nullable: false),
                        Rating = c.Double(nullable: false),
                        Image = c.Binary(),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Reservations", new[] { "Vehicle_Id" });
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.Reservations");
            DropTable("dbo.Clients");
        }
    }
}
