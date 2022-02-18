
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace ASMMAIN.Models
{
    [Table("Product")]

    public class Product
    {

        [Key]
        public int product_id { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        [Required]

        public string name { get; set; }

        [Column(TypeName = "money")]
        [Required]

        public float price { get; set; }

        [Required]
        public int quantity { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime createdDate {get;set;}
 
        [Column(TypeName = "ntext")]
        public string description { get; set; }

        [StringLength(100)]
        public string image_url { get; set; }

        public int category_id { get; set; }

        [ForeignKey("category_id")]
        public Category category { get; set; }
    }
}