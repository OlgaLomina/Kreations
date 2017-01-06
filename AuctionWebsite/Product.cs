using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{ 


    public class Product
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Auction> Auctions { get; set; }
    }
}
