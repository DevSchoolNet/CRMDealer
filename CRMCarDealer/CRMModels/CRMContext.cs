using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMModels
{
    public class CRMContext : DbContext
    {

        public CRMContext() : base("ExternalConnection") { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Prospect> Prospects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<TestCar> TestCars { get; set; }
        public DbSet<DriveTest> DriveTests { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
