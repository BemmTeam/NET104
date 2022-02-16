using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace ASMMAIN.Models
{
   

    public class User : IdentityUser
    {
        
        [StringLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        public string HomeAddress {get;set;}

        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string FullName {get;set;}
    }
}