using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Models;
public class NorthwindDbContext: DbContext
{
    public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options): base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Region> Region { get; set; }
    public DbSet<Shipper> Shippers { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Territory> Territories { get; set; }
}
