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

        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; }

        [ForeignKey("Auction")]
        public int AuctionId { get; set; }
        public virtual Auction Auction { get; set; }

        #endregion

        #region Constructor
        public Bid(decimal BidPrice, int BuyerId, int AuctionId)
        {
            this.BidPrice = BidPrice;
            this.BuyerId = BuyerId;
            this.AuctionId = AuctionId;
        }

        public Bid()
        {

        }
        #endregion

    }
}
