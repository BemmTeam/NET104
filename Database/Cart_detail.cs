

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ASMMAIN.Models
{
    [Table("Cart_detail")]

    public class Cart_detail {

       
       [Required]
        public int product_quantily { get; set; }


        public int cart_id { get; set; }

        public int product_id { get; set; }

        
        [ForeignKey("cart_id")]
        public Cart cart { get; set; }

        
        [ForeignKey("product_id")]
        public Product product { get; set; }
    }
}