using Microsoft.EntityFrameworkCore;
namespace DatingApp.API.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}