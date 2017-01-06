using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Payment : Buyer
    {        
        enum PaymentType
        {
            Visa = 0,
            AmericanExpress,
            MasterCard,
            Discover
        }
    }
}
