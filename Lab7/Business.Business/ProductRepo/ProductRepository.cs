using System;
using System.Collections.Generic;
using Domain;
using Persistence;
using System.Linq;

namespace Business.Business.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDatabaseService _databaseService;

        public void Add(ProductData product) => _databaseService.Products.Add(product);

        public void Delete(Guid id) => _databaseService.Products.Remove(GetById(id));

        public void Edit(ProductData product) => _databaseService.Products.Update(product);

        public IReadOnlyList<ProductData> GetAll()
        {
            return _databaseService.Products.ToList();
        }

        public ProductData GetById(Guid id)
        {
            return _databaseService.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
