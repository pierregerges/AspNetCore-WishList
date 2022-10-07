using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        // Create a constructor and invoke the base (DbContext) constructor 
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
