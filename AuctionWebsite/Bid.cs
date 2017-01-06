using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Bid
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        public decimal BidPrice { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual Auction Auction { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public Order Order { get; set; }
        #endregion

    }
}
