using System.ComponentModel.DataAnnotations;
    

namespace RfidAPI.Models
{
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