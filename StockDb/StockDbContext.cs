using StockDb.Entities;
using StockDb.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDb
{
   public class StockDbContext
    {
        public partial class StockContext : DbContext
        {
            public StockContext()
                : base("Connect")
            {

            }
            static StockContext()
            {
                Database.SetInitializer<StockContext>(null);
            }

            public DbSet<Category> Categories { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<OrderDetail> OrderDetails { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Region> Regions { get; set; }
            public DbSet<Shipper> Shippers { get; set; }
            public DbSet<Supplier> Suppliers { get; set; }
            public DbSet<sysdiagram> sysdiagrams { get; set; }
            public DbSet<Territory> Territories { get; set; }
            public DbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
            public DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
            public DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
            public DbSet<OrderSubtotal> OrderSubtotals { get; set; }

         
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Configurations.Add(new CategoryMap());
                modelBuilder.Configurations.Add(new CustomerMap());
                modelBuilder.Configurations.Add(new EmployeeMap());
                modelBuilder.Configurations.Add(new OrderDetailMap());
                modelBuilder.Configurations.Add(new OrderMap());
                modelBuilder.Configurations.Add(new ProductMap());
                modelBuilder.Configurations.Add(new RegionMap());
                modelBuilder.Configurations.Add(new ShipperMap());
                modelBuilder.Configurations.Add(new SupplierMap());
                modelBuilder.Configurations.Add(new sysdiagramMap());
                modelBuilder.Configurations.Add(new TerritoryMap());
                modelBuilder.Configurations.Add(new Alphabetical_list_of_productMap());
                modelBuilder.Configurations.Add(new AlphabeticalListOfProductMap());
                modelBuilder.Configurations.Add(new OrderDetailsExtendedMap());
                modelBuilder.Configurations.Add(new OrderSubtotalMap());
            }
        }

        public IQueryable<T> Set<T>()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
