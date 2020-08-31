using Data.Config;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EF
{
    public class eShopDBContext:DbContext
    {
        public eShopDBContext (DbContextOptions options) :base(options)
        {         
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products;
        public DbSet<Category> Categories;
        public DbSet<AppConfig> AppConfigs;
        public DbSet<CategoryTranslation> CategoryTranslations;
        public DbSet<Language> Languages;
        public DbSet<Contact> Contacts;
        public DbSet<ProductTranslation> ProductTranslations;
        public DbSet<Order> Orders;
        public DbSet<OrderDetail> OrderDetails;
        public DbSet<ProductInCategory> ProductInCategories;
        public DbSet<Promotion> Promotions;
        public DbSet<Transaction> Transactions;
        public DbSet<Cart> Carts;
    }
}
