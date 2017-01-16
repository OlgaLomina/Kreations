using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Auction
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        public DateTime BeginTime { get; set; } //start time of the Auction

        public TimeSpan Duration { get; set;} //duration of the Auction  

        public int HighestBidId { get; set; }
        
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; } //one Auction to one sale       

        public virtual ICollection<Bid> Bids { get; set; } //one Auction can have many bids 

        #endregion
        
        #region Constructor
        public Auction(int SaleId) //taking only parameter SaleId for testing purpose
        {
            TimeSpan duration = new TimeSpan(0, 12, 0, 0, 0); //default one 12 hr duration for bidding, to be revised that seller can set the duration
            this.Duration = duration;
            this.BeginTime = DateTime.Now; //begin time starts when object is created, for testing only
            this.SaleId = SaleId;

        }

        public Auction()
        {

        }
        #endregion
        #region methods
        public static void GetHighestBid(int auctionId)
        {
            using (var model = new KreationModel())
            {
                var bids = model.Bids.Where(b=>b.AuctionId == auctionId).ToList();
                var HighestBid = bids.OrderByDescending(p => p.BidPrice).First();
                Auction auction = (from Auction in model.Auctions
                                   where Auction.Id == auctionId
                                   select Auction).Single();
                auction.HighestBidId = HighestBid.Id;
                model.SaveChanges();

            }
            
        }
        #endregion


    }
}
