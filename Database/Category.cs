using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASMMAIN.Models
{
    [Table("Category")]

    public class Category {
        
        [Key]
        public int category_id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string name { get; set; }
    }
}