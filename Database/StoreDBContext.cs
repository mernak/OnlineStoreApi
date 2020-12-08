using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreApi.Entities;

namespace StoreApi.Database
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<ProductEntity>().HasMany(p => p.ProductDetails).WithOne(d => d.Product).HasForeignKey(d => d.ProductId);
            modelBuilder.Entity<OrderEntity>().HasMany(o => o.Products);
            modelBuilder.Entity<OrderEntity>().HasOne(o => o.Department);
            modelBuilder.Entity<DepartmentEntity>().HasMany(d => d.Orders).WithOne(o => o.Department).HasForeignKey(o => o.DepartmentId);

        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ProductDetailsEntity> ProductDetails { get; set; }
    }
}
