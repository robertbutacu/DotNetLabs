using System;
using System.Collections.Generic;
using System.Text;
using Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public sealed class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<StockModel> StockModels { get; set; }
        public DbSet<StockRecord> StockRecords { get; set; }
    }
}
