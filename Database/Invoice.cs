using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ASMMAIN.Models
{
    [Table("invoice")]

    public class Invoice {

        [Key]
        public int invoice_id { get; set; }

        public DateTime? created_date { get; set; }

        [Required]
        public bool status { get;set; }
        

        public int? cart_id { get; set; }
        

        public string UserId { get; set; }

        [ForeignKey("cart_id")]
        public Cart cart { get; set; }

        [ForeignKey("UserId")]
        public User user { get; set; }

    }
}