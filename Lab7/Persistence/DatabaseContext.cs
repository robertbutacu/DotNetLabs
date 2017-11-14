﻿using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DatabaseContext: DbContext, IDatabaseService
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<ProductData> Products { get ; set; }
    }
}
