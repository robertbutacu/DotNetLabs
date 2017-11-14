using Domain;
using System;
using System.Collections.Generic;

namespace Business.Business
{
    public interface IProductRepository
    {
        IReadOnlyList<ProductData> GetAll();
        ProductData GetById(Guid id);
        void Add(ProductData stock);
        void Edit(ProductData stock);
        void Delete(Guid id);
    }
}
