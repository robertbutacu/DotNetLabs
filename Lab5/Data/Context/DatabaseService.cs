using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Context 
{
    public class DatabaseService : DbContext, IDatabaseService
    {
    public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
    {
    }

    public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}
