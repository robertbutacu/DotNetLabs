using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public partial class DatabaseContext: DbContext, IDatabaseService
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<ProductData> ProductDatas { get; set; }
    }
}
