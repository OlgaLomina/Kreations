using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{ 


    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int ProductAttributeId { get; set; }
        
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Auction> Auctions { get; set; }

        /// <summary>
        ///product's attributes are in Product Attribute class
        /// </summary>
        
    }
}
