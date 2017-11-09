using Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public interface IDatabaseContext
    {
        DbSet<StockModel> StockModels { get; set; }
        DbSet<StockRecord> StockRecords { get; set; }
        int SaveChanges();
    }
}