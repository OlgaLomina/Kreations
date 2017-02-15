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

        /// <summary>
        /// to which buyer the cart belongs to
        /// </summary>
        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; }

        /// <summary>
        /// a cart can contain multiple sales
        /// </summary>
        public virtual ICollection<Sale> Sales { get; set; } //one buyer to many bids             
        #endregion

        #region Constructors
        /// <summary>
        /// parameterless constructor
        /// </summary>
        public Cart()
        {

        }

        /// <summary>
        /// constructor to create a cart for specific buyer
        /// </summary>
        /// <param name="BuyerId">integer of the buyer id</param>
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
        /// <summary>
        /// add a sale to a specific cart
        /// </summary>
        /// <param name="CartId">integer id of the cart to add sale to</param>
        /// <param name="SaleId">integer id of the sale to be added</param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns>List of saved sales</returns>             
        public List<Sale> GetCartList()
        {
            using (var model = new KreationModel())
            {
                Cart cart = model.Carts.FirstOrDefault(i => i.Id == this.Id);
                return cart.Sales.ToList();
            }
        }
        #endregion
    }
}
