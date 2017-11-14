using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public interface IDatabaseService
    {
        DbSet<ProductData> Products { get; set; }
    }
}
