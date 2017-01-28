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

        /// <summary>
        /// start time of the Auction
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// duration of the Auction  
        /// </summary>
        public TimeSpan Duration { get; set;}

        /// <summary>
        /// end time of the Auction
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// this property saves the id of the highest Bid received in an auciton
        /// </summary>
        public int HighestBidId { get; set; } 

        /// <summary>
        /// the minimum increment of the bid, seller to decide whether to set one
        /// </summary>
        public decimal MinIncrement { get; set; }
        
        /// <summary>
        /// the Sale that the auction is associated to
        /// </summary>
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; } //one Auction to one sale       

        /// <summary>
        /// Bids received in this auction
        /// </summary>
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

        /// <summary>
        /// this method updates the HighestBidId property to store the highest bid Id
        /// </summary>
        /// <param name="auctionId"></param>
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

        /// <summary>
        /// get end time of the auction 
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetEndTime()
        {
            return this.BeginTime + this.Duration;
        }

        #endregion


    }
}
