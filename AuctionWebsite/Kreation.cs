using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Kreation's static class
/// for now it contains methods to add objects to database 
/// </summary>

namespace Kreation
{
    public static class Kreation
    {
        #region Methods
        /// <summary>
        /// method to add a Buyer to the website
        /// </summary>
        /// <param name="buyer"></param>
        public static void AddBuyer(Buyer Buyer)
        {
            using (var model = new KreationModel()) 
            {                
                model.Buyers.Add(Buyer); 
                model.SaveChanges(); 
            }       
            
        }

       
        /// <summary>
        /// method to add a review to the website
        /// </summary>
        /// <param name="buyer"></param>
        public static void AddReview(Review Review)
        {
            using (var model = new KreationModel())
            {
                model.Reviews.Add(Review);
                model.SaveChanges();
            }
            
        }

        /// <summary>
        /// method to add an auction to the website
        /// </summary>
        /// <param name="Auction"></param>
        public static void AddAuction(Auction Auction)
        {
            using (var model = new KreationModel())
            {
                model.Auctions.Add(Auction);
                model.SaveChanges();
            }
        }

        /// <summary>
        /// method to add an auction to the website
        /// </summary>
        /// <param name="Order"></param>
        public static void AddOrder(Order Order)
        {
            using (var model = new KreationModel())
            {
                model.Orders.Add(Order);
                model.SaveChanges();
            }
        }

        public static void AddSeller(Seller Seller)
        {
            using (var model = new KreationModel())
            {
                model.Sellers.Add(Seller);
                model.SaveChanges();
            }
        }

        public static void AddProduct(Product Product)
        {
            using (var model = new KreationModel())
            {
                model.Products.Add(Product);
                model.SaveChanges();
            }
        }

        public static void AddSale(Sale Sale)
        {
            using (var model = new KreationModel())
            {
                model.Sales.Add(Sale);
                model.SaveChanges();
            }
        }

        public static void AddBid(Bid Bid)
        {
            using (var model = new KreationModel())
            {
                model.Bids.Add(Bid);
                model.SaveChanges();
            }
        }



        #endregion
    }
}
