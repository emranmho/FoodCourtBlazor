using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodCourtBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Fruit" },
                new Category { Id = Guid.NewGuid(), Name = "Vegetable" },
                new Category { Id = Guid.NewGuid(), Name = "Meat" }
            );
        }
    }
}
