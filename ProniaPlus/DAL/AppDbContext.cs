using Microsoft.EntityFrameworkCore;
using ProniaPlus.Models;

namespace ProniaPlus.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Slide> Slides { get; set; }
    }
}
