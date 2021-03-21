using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RfidAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int key { get; set; }
        
        public string name { get; set; }
        public bool gender { get; set; }
        public int permission { get; set; }
        public string faceInfo { get; set; }
        
    }
}