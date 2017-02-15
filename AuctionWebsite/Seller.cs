using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Seller
    {
        #region Properties
        /// <summary> int [key] Id of the Seller </summary>
        [Key]
        public int Id { get; set; }
        /// <summary> string first name of the seller </summary>
        public string FirstName { get; set; }
        /// <summary> string last name of the seller </summary>
        public string LastName { get; set; }
        /// <summary> DateTime the time when the seller register </summary>
        public DateTime MemberSince { get; set; }
        /// <summary> int country id of seller's country </summary>
        public int CountryId { get; set; }
        /// <summary> a collection of sales by this seller </summary>
        public virtual ICollection<Sale> Sales { get; set; } //one seller with multiple sales
        /// <summary> a collection of reviews for this seller  </summary>
        public virtual ICollection<Review> Reviews { get; set; } //one seller with multiple reviews
        #endregion

        #region Constructor
        public Seller()
        {
            MemberSince = DateTime.Now;
        }
        
        #endregion
    }
}
