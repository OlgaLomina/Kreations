namespace Kreation
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KreationModel : DbContext
    {
        // Your context has been configured to use a 'KreationModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AuctionWebsite.KreationModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KreationModel' 
        // connection string in the application configuration file.
        public KreationModel()
            : base("name=KreationModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }       
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}