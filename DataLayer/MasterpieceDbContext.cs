using System;
using System.Data.Entity;
using BusinessLayer;

namespace DataLayer
{
    public class MasterpieceDbContext : DbContext
    {
        public DbSet<Masterpiece> Masterpieces { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        public MasterpieceDbContext() : base("MasterpiecesDb")
        {
        }
    }
}
