using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; } //one review is associate with one buyer

        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; } //one review is associate with one seller

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } //one review is associate with one product
        #endregion



    }
}
