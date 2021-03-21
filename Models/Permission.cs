using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RfidAPI.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key] public int id { get; set; }
        public string role_name { get; set; }
        
    }
}