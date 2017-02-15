using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreation;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace KreationTests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            
            using (var model = new KreationModel())
            {

                Cart cart = model.Carts.FirstOrDefault(i => i.Id == 5);               
                List<Sale> sales = cart.GetCartList();
            }

        }
    }
}
