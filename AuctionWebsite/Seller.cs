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
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime MemberSince { get; set; } //the time when seller first register
        public int CountryId { get; set; }
        public virtual ICollection<Sale> Sales { get; set; } //one seller with multiple sales
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
