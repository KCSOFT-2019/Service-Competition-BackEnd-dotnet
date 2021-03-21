using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RfidAPI.Models
{
    [Table("Repo")]
    public class Repo
    {
        [Key]
        public int RepoId { get; set; }
        public string info { get; set; }
        public int managerId { get; set; }
        [ForeignKey("managerId")]
        public virtual User manager { get; set; }
    }
}