using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Order
    {
        #region Properties
        [Key]
        public int Id { get; set; } 
        public DateTime DateCreated { get; set; } //time when the order got created
        [ForeignKey("Auction")]
        public int AuctionId { get; set; }
        public virtual Auction Auction { get; set; }

        #endregion

        #region Constructor
        public Order()
        {
            DateCreated = DateTime.Now;
        }
        #endregion

    }
}
