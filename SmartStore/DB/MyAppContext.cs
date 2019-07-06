using Microsoft.EntityFrameworkCore;
using SmartStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.DB
{
    public class MyAppContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<ItemPrice> ItemPrices { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<SpecificationUnit> SpecificationUnits { get; set; }

        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options)
        {
        }

        public MyAppContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasOne(c => c.Parent)
                .WithMany(c => c.Children)
                .HasForeignKey(c => c.ParentId);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Items)
                .WithOne(i => i.Category)
                .HasForeignKey(i => i.CategoryId);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.Images)
                .WithOne(i => i.Item)
                .HasForeignKey(i => i.ItemId);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.PriceHistory)
                .WithOne(i => i.Item)
                .HasForeignKey(i => i.ItemId);

            modelBuilder.Entity<Specification>()
                .HasMany(s => s.Items)
                .WithOne(i => i.Specification)
                .HasForeignKey(i => i.SpecificationId);

            modelBuilder.Entity<Specification>()
                .HasMany(s => s.Units)
                .WithOne(i => i.Specification)
                .HasForeignKey(s => s.SpecificationId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = DBConfigService.Carregar();
            //optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=softstore;User Id=postgres;Password=postgre;");
            optionsBuilder.UseNpgsql($"Server={config.Server};Port={config.Port};Database={config.Database};User Id={config.User};Password={config.Password};");
        }
    }
}
