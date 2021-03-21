using System.ComponentModel.DataAnnotations;
namespace RfidAPI.Models
{
    public class Permission
    {
        [Key] public int id { get; set; }
        public string role_name { get; set; }
        
    }
}