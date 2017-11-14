using System;
using System.Collections.Generic;
using Domain;
using Persistence;
using System.Linq;

namespace Business.Business.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDatabaseService _databaseService;

        public ProductRepository(IDatabaseService databaseService) => _databaseService = databaseService;

        public void Add(ProductData product) => _databaseService.ProductDatas.Add(product);

        public void Delete(Guid id) => _databaseService.ProductDatas.Remove(GetById(id));

        public void Edit(ProductData product) => _databaseService.ProductDatas.Update(product);

        public IReadOnlyList<ProductData> GetAll()
        {
            return _databaseService.ProductDatas.ToList();
        }

        public ProductData GetById(Guid id)
        {
            return _databaseService.ProductDatas.FirstOrDefault(p => p.Id == id);
        }
    }
}
