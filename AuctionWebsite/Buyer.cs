using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Buyer
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime MemberSince { get; set; } //the time when buyer first register
        public int CountryId { get; set; } //one buyer to one country
        public virtual ICollection<Bid> Bids  { get; set; } //one buyer to many bids     
        public virtual ICollection<Order> Orders { get; set; } //one buyer to many orders
        public virtual ICollection<Review> Reviews { get; set; } //one buyer to many reviews
        #endregion

        #region Constructor
        public Buyer()
        {
            MemberSince = DateTime.Now; //record the date time when Buyer object gets created
        }
        #endregion



    }
}
