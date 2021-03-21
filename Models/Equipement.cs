using System.ComponentModel.DataAnnotations;
namespace RfidAPI.Models
{
    public class Equipement
    {
        [Key]
        public int deviceId { get; set; }
        public string deviceName { get; set; }
        public int status { get; set; }
    }
}