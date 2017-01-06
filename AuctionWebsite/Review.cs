using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public enum ReviewType
    {
        BuyerReview, //seller's buyer review
        SellerReview, //buyer's seller review
        ProductReview //buyer's product review
    }
    public class Review
    {
        #region Properties 
        [Key] 
        public int Id { get; set; }
        public ReviewType Type { get; set; }
        public String ReviewContent { get; set; } //the content of the review
        public virtual Buyer Buyer { get; set; } //one review is associate with one buyer
        public virtual Seller Seller { get; set; } //one review is associate with one seller
        public virtual Product Product { get; set; } //one review is associate with one product
        #endregion



    }
}
