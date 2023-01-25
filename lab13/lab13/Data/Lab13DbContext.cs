using lab13.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab13.Data
{
    public class Lab13DbContext : IdentityDbContext
    {
        public Lab13DbContext(DbContextOptions<Lab13DbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(a => a.Articles)
                .WithOne(c => c.Category)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Article>()
                .HasOne(c => c.Category)
                .WithMany(a => a.Articles)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}