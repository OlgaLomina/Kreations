using Kreation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    public class Cart
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual ICollection<Sale> Sales { get; set; } //one buyer to many bids             
        #endregion

        #region Constructors
        public Cart()
        {

        }
        public Cart(int BuyerId)
        { 
            using (var model = new KreationModel())
            {
                
                Buyer buyer = model.Buyers.FirstOrDefault(i => i.Id == BuyerId); ;
                this.Buyer = buyer;
                this.BuyerId = BuyerId;
                
            }
            
        }
        #endregion

        #region Methos
        public static void AddToCart(int CartId, int SaleId)
        {
            using (var model = new KreationModel())
            {

                Cart cart = model.Carts.FirstOrDefault(i => i.Id == CartId);
                Sale sale = model.Sales.FirstOrDefault(i => i.Id == SaleId); 
                cart.Sales.Add(sale);
                model.SaveChanges();

            }
            
        }
        #endregion
    }
}
