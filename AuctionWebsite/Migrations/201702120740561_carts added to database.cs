namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartsaddedtodatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Sales", "Cart_Id", c => c.Int());
            CreateIndex("dbo.Sales", "Cart_Id");
            AddForeignKey("dbo.Sales", "Cart_Id", "dbo.Carts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "Cart_Id", "dbo.Carts");
            DropIndex("dbo.Sales", new[] { "Cart_Id" });
            DropColumn("dbo.Sales", "Cart_Id");
            DropTable("dbo.Carts");
        }
    }
}
