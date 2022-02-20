using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using ASMMAIN.Models;
using System.Collections.Generic;

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

        [Column(TypeName = "Nvarchar(2000)")]
        public string productList {get;set;}

        public float total {get;set;}

        [NotMapped]
        
        public List<CartItem> items {get;set;}



    }
}