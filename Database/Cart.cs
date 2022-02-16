using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ASMMAIN.Models
{
    [Table("Cart")]
    public class Cart
    {

        [Key]
        public int cart_id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? created_date { get; set; }

        [Required]
        public bool status { get; set; }

        [Required]
        
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User user { get; set; }
    }
}