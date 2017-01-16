using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// main program,
/// I created this for test only
/// </summary>

namespace Kreation
{
    class Program
    {
        static void Main(string[] args)
        {
            ////to add a seller 
            //Seller nicole = new Seller();
            //nicole.FirstName = "Nicole";
            //nicole.LastName = "Pi";
            //Kreation.AddSeller(nicole);

            ////to add a product
            //Product product1 = new Product();
            //Kreation.AddProduct(product1);

            ////to add a sale
            //Sale sale1 = new Sale(1, 1);
            //Kreation.AddSale(sale1);

            ////to add an auction to the database
            //Auction TestAuction = new Auction(1);
            //Kreation.AddAuction(TestAuction);

            ////to add a buyer to the database                         
            //Buyer buyer2 = new Buyer();
            //buyer2.FirstName = "Buyer";
            //buyer2.LastName = "2";
            //Kreation.AddBuyer(buyer2);

            //Buyer buyer3 = new Buyer();
            //buyer3.FirstName = "Buyer";
            //buyer3.LastName = "3";
            //Kreation.AddBuyer(buyer3);

            ////add a bid
            //Bid bid1 = new Bid(200, 1, 1);
            //Kreation.AddBid(bid1);

            //Bid bid2 = new Bid(400, 2, 1);
            //Kreation.AddBid(bid2);

            //Bid bid3 = new Bid(600, 3, 1);
            //Kreation.AddBid(bid3);

            //to add an order to the database
            //Order TestOrder = new Order();            
            //Kreation.AddOrder(TestOrder);

            //to add a review to the database
            //Review TestReview = new Review();
            //TestReview.Type = ReviewType.BuyerReview;
            //TestReview.ReviewContent = "This is a test review.";
            //Kreation.AddReview(TestReview);

            Auction.GetHighestBid(1);
        }
    }
}
