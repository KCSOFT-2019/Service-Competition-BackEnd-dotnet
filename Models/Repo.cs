using System.ComponentModel.DataAnnotations;

namespace RfidAPI.Models
{
    public class Repo
    {
        [Key]
        public int id { get; set; }
        public string info { get; set; }
        public int managerId { get; set; }
    }
}