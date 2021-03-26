using System.ComponentModel.DataAnnotations;

namespace RfidAPI.Models
{
    public class LoginUser
    {
        [Required,MinLength(2)]
        public string UserName { get; set; }
        
        [MinLength(6)]
        public string Password { get; set; }
    }
}