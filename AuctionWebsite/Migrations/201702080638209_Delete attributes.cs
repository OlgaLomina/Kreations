namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deleteattributes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attributes", "ProductAttribute_Id", "dbo.ProductAttributes");
            DropForeignKey("dbo.ProductAttributes", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductAttributes", new[] { "ProductId" });
            DropIndex("dbo.Attributes", new[] { "ProductAttribute_Id" });
            DropColumn("dbo.Products", "ProductAttributeId");
            DropTable("dbo.ProductAttributes");
            DropTable("dbo.Attributes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Attributes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductAttribute_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductAttributes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Condition = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "ProductAttributeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Attributes", "ProductAttribute_Id");
            CreateIndex("dbo.ProductAttributes", "ProductId");
            AddForeignKey("dbo.ProductAttributes", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Attributes", "ProductAttribute_Id", "dbo.ProductAttributes", "Id");
        }
    }
}
