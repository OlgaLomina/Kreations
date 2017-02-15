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

        /// <summary>DateTime start time of the Auction</summary>
        public DateTime BeginTime { get; set; }

        /// <summary>TimeSpan duration of the Auction</summary>
        public TimeSpan Duration { get; set;}

       
        /// <summary>int the id of the highest Bid received in an auciton</summary>
        public int WinningBidId { get; set; } 

        /// <summary>decimal the minimum increment of the bid, default 0</summary>
        public decimal MinIncrement { get; set; }
        
        /// <summary>int Id of the Sale that the auction is associated to</summary>
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; } //one Auction to one sale       

        /// <summary>collection of Bids received in this auction</summary>
        public virtual ICollection<Bid> Bids { get; set; } //one Auction can have many bids 

        #endregion
        
        #region Constructor
        public Auction(int SaleId, TimeSpan Duration, decimal MinIncrement) 
        {
            this.SaleId = SaleId;
            this.Duration = Duration;
            this.MinIncrement = MinIncrement;
            this.BeginTime = DateTime.Now;
        }

        public Auction(int SaleId)
        {
            this.Duration = new TimeSpan(1, 0, 0, 0, 0); //default 1 day duration for bidding
            this.BeginTime = DateTime.Now; //begin time starts when auction object is created
            this.SaleId = SaleId;
            this.MinIncrement = 0; //default no min increment for bids

        }

        public Auction()
        {

        }

        #endregion

        #region methods


        /// <summary>
        /// return the highest bid id of this auction, *this does not update the database, just return the current highest bid id
        /// </summary>
        /// <returns>int id of the highest bid</returns>
        public int GetCurrentHighestBidId()
        {            
                List<Bid> bids = this.Bids.ToList(); //get list of bids for this auction
                Bid highestBid = bids.OrderByDescending(p => p.BidPrice).ToList()[0]; //get the highest bid in the bids list
                return highestBid.Id;
            
        }
        
        /// <summary>
        /// get end time of the auction 
        /// </summary>
        /// <returns>DateTime end time of the auction</returns>
        public DateTime GetEndTime()
        {
            return this.BeginTime + this.Duration;
        }

        /// <summary>
        /// update the database in the end of the auction to store the winning bid id
        /// </summary>
        public void GetWinningBid()
        {
            using (var model = new KreationModel())
            {                             
                Auction auction = (from Auction in model.Auctions where Auction.Id == this.Id select Auction).Single();
                auction.WinningBidId = this.GetCurrentHighestBidId();
                model.SaveChanges();
            }

        }


        #endregion


    }
}
