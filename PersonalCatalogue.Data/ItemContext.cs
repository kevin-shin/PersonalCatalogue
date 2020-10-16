using System;
using Microsoft.EntityFrameworkCore;

namespace PersonalCatalogue.Data
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options) { }

        public DbSet<Item> items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>();

        }
    }


}
