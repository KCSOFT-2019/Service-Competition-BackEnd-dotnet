using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace RfidAPI.Models
{
    
    public enum RequestStatus
    {
        ok,
        no,
        notYet
        
    }
    [Table("Log")]
    public class Log
    {
        [Key] public int LogId { get; set; }
        
        public string from_UserId { get; set; }
        public string to_UserId { get; set; }
        public int status { get; set; }//
        public RequestStatus requestStatus { get; set; }
        public string log { get; set; }
        public DateTime from_time { get; set; }
        public DateTime to_time { get; set; }
        
        [ForeignKey("from_UserId")]
        public virtual IUser FromUser { get; set; } 
        [ForeignKey("to_UserId")]
        public virtual IUser ToUser { get; set; }
    }
}