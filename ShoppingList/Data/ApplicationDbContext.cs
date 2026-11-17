using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingList.Data.Entities;

namespace ShoppingList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // Ако миграциите не работят – разкоментирайте:
            // Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductNote> ProductNotes { get; set; } = null!;
    }
}
