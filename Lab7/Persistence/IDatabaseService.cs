using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public interface IDatabaseService
    {
        DbSet<ProductData> ProductDatas { get; set; }
    }
}
