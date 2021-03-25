using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace RfidAPI.Models
{
    [Table("User")]
    public class User 
    {
        [Key]
        public int UserId { get; set; }
        
        public string UserName { get; set; }
        public bool gender { get; set; }
        public int permissionId { get; set; }
        public string faceInfo { get; set; }
        [ForeignKey("permissionId")]
        public virtual Permission permission { get; set; }
        
    }
}