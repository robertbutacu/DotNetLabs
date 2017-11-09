using System;
using System.Collections.Generic;
using Data.Domain.Entities;
using Data.Persistence;
using System.Linq;

namespace Business.Business.StockModelRepo
{
    public class StockModelRepository : IStockModel
    {
        private readonly IDatabaseContext _databaseService;

        public void Add(StockModel stock)
        {
            _databaseService.StockModels.Add(stock);
        }

        public void Delete(Guid id)
        {
            var stock = GetById(id);
            _databaseService.StockModels.Remove(stock);
        }

        public void Edit(StockModel stock)
        {
            _databaseService.StockModels.Update(stock);
        }

        public IReadOnlyList<StockModel> GetAll()
        {
            return _databaseService.StockModels.ToList();
        }

        public StockModel GetById(Guid id)
        {
            return _databaseService.StockModels.FirstOrDefault(s => s.Id == id);
        }
    }
}
