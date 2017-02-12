namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtocartmethod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buyers", "CartId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buyers", "CartId");
        }
    }
}
