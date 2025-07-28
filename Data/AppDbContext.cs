using Microsoft.EntityFrameworkCore;
using MyDatingAppAPI.Models;

namespace MyDatingAppAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }  
        public DbSet<AppUser> Users { get; set; }
    }
}
