using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionWebsite
{
    class Payment : Buyer
    {
        public Seller Seller
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        enum PaymentType
        {
            Visa = 0,
            AmericanExpress,
            MasterCard,
            Discover
        }
    }
}
