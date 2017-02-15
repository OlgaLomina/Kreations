using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation.Tests
{
    [TestClass()]
    public class AuctionTests
    {
        /// <summary>
        /// get the highest bid id of auction Id == 2, expect to get bid Id == 10
        /// </summary>
        [TestMethod()]
        public void GetCurrentHighestBidTest1()
        {
            using (var model = new KreationModel())
            {
                var auction2 = model.Auctions.FirstOrDefault(i => i.Id == 2); //get auction with Id == 2
                Assert.AreEqual(10, auction2.GetCurrentHighestBidId()); 
            }
        }

        /// <summary>
        /// get the highest bid id of auction Id == 5, expect to get bid Id == 8
        /// </summary>
        [TestMethod()]
        public void GetCurrentHighestBidTest2()
        {
            using (var model = new KreationModel())
            {
                var auction5 = model.Auctions.FirstOrDefault(i => i.Id == 5); //get auction with Id == 5
                Assert.AreEqual(8, auction5.GetCurrentHighestBidId()); //
            }
        }

        /// <summary>
        /// get the winning bid in the end of the auction 2, store the id to the database, expect bid id = 10 
        /// </summary>
        [TestMethod()]
        public void GetWinningBidTest1()
        {
            using (var model = new KreationModel())
            {
                var auction2 = model.Auctions.FirstOrDefault(i => i.Id == 2); //get auction with Id == 2
                auction2.GetWinningBid(); 
            }
        }

        /// <summary>
        /// get the winning bid in the end of the auction 5, store the id to the database, expect bid id = 8 
        /// </summary>
        [TestMethod()]
        public void GetWinningBidTest2()
        {
            using (var model = new KreationModel())
            {
                var auction5 = model.Auctions.FirstOrDefault(i => i.Id == 5); //get auction with Id == 5
                auction5.GetWinningBid();
            }
        }
    }
}