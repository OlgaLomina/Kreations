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
        [TestMethod()]
        public void GetEndTimeTest()
        {
            Auction auction1 = new Auction();
            auction1.BeginTime = DateTime.Now;
            auction1.Duration = new TimeSpan(0, 12, 0, 0, 0);
            System.Console.WriteLine(auction1.GetEndTime());

        }

        [TestMethod()]
        public void GetHighestBidTest()
        {
           
        }
    }
}