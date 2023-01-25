using lab12.Models;
using Microsoft.EntityFrameworkCore;
using lab12.ViewModels;

namespace lab12
{
    public class Lab12DbContext : DbContext
    {
        public Lab12DbContext(DbContextOptions<Lab12DbContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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