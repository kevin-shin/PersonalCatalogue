using System;
using Microsoft.EntityFrameworkCore;

namespace PersonalCatalogue.Data
{
    public class CatalogueDbContext : DbContext
    {
        public CatalogueDbContext(DbContextOptions<CatalogueDbContext> options) : base(options) { }

        public DbSet<Item> items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>();

        }
    }


}
