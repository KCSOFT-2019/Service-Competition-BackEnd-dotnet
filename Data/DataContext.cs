
using Microsoft.EntityFrameworkCore;
using RfidAPI.Models;

namespace RfidAPI.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Repo> Repos { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Log>  Logs { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        
        public DbSet<DeviceCount> DeviceCounts { get; set; }
    }
}