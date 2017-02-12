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
        /// method to add an order to the website
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

        /// <summary>
        /// method to add a seller
        /// </summary>
        /// <param name="Seller"></param>
        public static void AddSeller(Seller Seller)
        {
            using (var model = new KreationModel())
            {
                model.Sellers.Add(Seller);
                model.SaveChanges();
            }
        }

        /// <summary>
        /// add a product
        /// </summary>
        /// <param name="Product"></param>
        public static void AddProduct(Product Product)
        {
            using (var model = new KreationModel())
            {
                model.Products.Add(Product);
                model.SaveChanges();
            }
        }

        /// <summary>
        /// add a sale
        /// </summary>
        /// <param name="Sale"></param>
        public static void AddSale(Sale Sale)
        {
            using (var model = new KreationModel())
            {
                model.Sales.Add(Sale);
                model.SaveChanges();
            }
        }

        /// <summary>
        /// add a bid to the auction, it checks whether the bid price is larger than the current highest bid plus
        /// the minimum increment, if it is larger, add the bid to Bids table and update the current highest bid; 
        /// if it is less, bid will not be added to be Bids table and console will write error
        /// </summary>
        /// <param name="Bid"></param>
        public static void AddBid(Bid Bid)
        {
            int AuctionId = Bid.AuctionId;

            using (var model = new KreationModel())
            {
                int HighestBidId = model.Auctions.Where(a => a.Id == AuctionId).Single().HighestBidId;
                decimal HighestBidPrice = model.Bids.Where(b => b.Id == HighestBidId).Single().BidPrice;
                decimal MinBid = model.Auctions.Where(a => a.Id == AuctionId).Single().MinIncrement + HighestBidPrice;

                if (Bid.BidPrice >= MinBid)
                {
                    model.Bids.Add(Bid);
                    model.SaveChanges();
                    Auction.GetHighestBid(Bid.AuctionId);
                }
                else
                {
                    System.Console.WriteLine("You need to bid more than " + MinBid + " dollars.");
                }
            }
            Auction.GetHighestBid(Bid.AuctionId);
        }

        public static void AddCart(Cart Cart)
        {
            using (var model = new KreationModel())
            {
                model.Carts.Add(Cart);
                model.SaveChanges();
            }
        }
        #endregion
    }
}
