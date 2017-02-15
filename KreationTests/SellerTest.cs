using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreation;
using System.Linq;
using System.Collections.Generic;

namespace KreationTests
{
    [TestClass]
    public class SellerTest
    {
        /// <summary>
        /// test Seller.Sales to return a list of Sales by a specific seller
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            using (var model = new KreationModel())
            {
                Seller seller1 = model.Sellers.FirstOrDefault(i => i.Id == 1); //get Seller with Id == 1
                List<Sale> sales = seller1.Sales.ToList(); //get the list of total sales by the seller
                
                //should return sales list with Id 2, 3, 4
                Assert.AreEqual(2, sales[0].Id); 
                Assert.AreEqual(3, sales[1].Id);
                Assert.AreEqual(4, sales[2].Id);
            }
        }
    }
}
