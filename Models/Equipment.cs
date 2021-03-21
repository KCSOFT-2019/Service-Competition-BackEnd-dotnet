using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RfidAPI.Models
{
    [Table("Equipment")]
    public class Equipment
    {
        [Key]
        public int deviceId { get; set; }
        public string deviceName { get; set; }
        public int status { get; set; }
    }
}