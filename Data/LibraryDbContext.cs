using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RfidAPI.Models;

namespace RfidAPI.Data
{
    public class LibraryDbContext : IdentityDbContext<IUser, IRole, string>
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
            
        }
        public DbSet<IUser> IUsers { get; set; }
        public DbSet<IRole> Iroles { get; set; }
    }
}