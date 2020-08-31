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
