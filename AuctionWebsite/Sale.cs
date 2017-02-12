using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Sale
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
     

        // public virtual Auction Auction { get; set; }
        // not able to create database with the line that got commented above, why? error message below:
        // Message=Unable to determine the principal end of an association between the types 'Kreation.Sale' and 'Kreation.Auction'. 
        // The principal end of this association must be explicitly configured using either the relationship fluent API or data annotations.
        #endregion

        #region Constructor
        public Sale()
        {

        }
        public Sale(int SellerId, int ProductId)
        {
            this.SellerId = SellerId;
            this.ProductId = ProductId;
        }
        
        #endregion
    }
}
