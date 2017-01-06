using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public virtual Buyer Buyer { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Product Product { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; } //time when the order got created
        #endregion

        #region Constructor
        public Order()
        {
            DateCreated = DateTime.Now;
        }
        #endregion
    }
}
