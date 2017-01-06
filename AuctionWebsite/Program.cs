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
            //test to add a review to the database
            Review TestReview = new Review();
            TestReview.Type = ReviewType.BuyerReview;
            TestReview.ReviewContent = "This is a test review.";
            Kreation.AddReview(TestReview);

            //test to add a buyer to the database                         
            Buyer TestBuyer = new Buyer();
            TestBuyer.FirstName = "Nick";
            TestBuyer.LastName = "Pi";
            Kreation.AddBuyer(TestBuyer);

            //test to add an auction to the database
            Auction TestAuction = new Auction();
            TestAuction.BeginTime = DateTime.Now;
            Kreation.AddAuction(TestAuction);

            //test to add an order to the database
            Order TestOrder = new Order();
            TestOrder.Price = 500;
            Kreation.AddOrder(TestOrder);
        }
    }
}
