using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Models;

namespace PortsShop.Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Address> Address { get; set; }
    public DbSet<Branch> Branch { get; set; }
    public DbSet<Cart> Cart{ get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<PaymentType> PaymentType { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Price> Price { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<SKU> SKU { get; set; }
    public DbSet<Stock> Stock { get; set; }
    public DbSet<Store> Store { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        
    }


}
