using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public virtual Sale Sale { get; set; } //one Auction to one sale
        public virtual ICollection<Bid> Bids { get; set; } //one Auction can have many bids
        #endregion

        #region Constructor
        public Auction()
        {
            
        }
        #endregion
    }
}
