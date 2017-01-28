using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreation
{
    /// <summary>
    /// product's typical attributes, such as name, description, condition, 
    /// other product specific attributes are in the collection of Attribute
    /// </summary>
    public class ProductAttribute
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Condition { get; set; }
        public ICollection<Attribute> Attributes { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }




    }
}
