using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : base (options) { }
        public DbSet<SalesWebMvc.Models.Department> Department { get; set; }
        public DbSet<SalesWebMvc.Models.SalesRecord> SalesRecords { get; set; }
        public DbSet<SalesWebMvc.Models.Seller> Sellers { get; set; }

    }
}
