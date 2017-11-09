using System;
using System.Collections.Generic;
using Data.Domain.Entities;
using Data.Persistence;
using System.Linq;

namespace Business.Business.StockModelRepo
{
    public class StockModelRepository : IStockModel
    {
        private readonly IDatabaseContext _databaseservice;

        public void Add(StockModel stock)
        {
            _databaseservice.StockModels.Add(stock);
        }

        public void Delete(Guid id)
        {
            var stock = GetById(id);
            _databaseservice.StockModels.Remove(stock);
        }

        public void Edit(StockModel stock)
        {
            _databaseservice.StockModels.Update(stock);
        }

        public IReadOnlyList<StockModel> GetAll()
        {
            return _databaseservice.StockModels.ToList();
        }

        public StockModel GetById(Guid id)
        {
            return _databaseservice.StockModels.FirstOrDefault(s => s.Id == id);
        }
    }
}
