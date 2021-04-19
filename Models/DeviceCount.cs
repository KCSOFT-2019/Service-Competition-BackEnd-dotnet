using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RfidAPI.Models
{
    [Table("DeviceCount")]
    public class DeviceCount
    {
        [Key] public int? deviceCountId { get; set; }
        
        public string deviceName { get; set; }
        
        public int nowCount { get; set; }
        
        public int totalCount { get; set; }
        
        public string imageUrl { get; set; }
        
        
        [ForeignKey("deviceName")] public virtual Equipment equip { get; }
    }
}