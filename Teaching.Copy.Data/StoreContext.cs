using Teaching.Copy.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Teaching.Copy.Domain.Orders;

namespace Teaching.Copy.Data;

public class StoreContext : DbContext
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder =
            new DbContextOptionsBuilder<StoreContext>();

        optionsBuilder.UseSqlite(
            "Data Source=../Registrar.sqlite");

        return new StoreContext(optionsBuilder.Options);
    }
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        DbInitializer.Initialize(builder);
    }
}
