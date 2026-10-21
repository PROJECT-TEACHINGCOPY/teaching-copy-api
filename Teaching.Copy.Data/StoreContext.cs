using Teaching.Copy.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Teaching.Copy.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}