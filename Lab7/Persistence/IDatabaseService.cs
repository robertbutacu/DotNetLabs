using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public interface IDatabaseService
    {
        DbSet<Domain.ProductData> ProductDatas { get; set; }
    }
}
