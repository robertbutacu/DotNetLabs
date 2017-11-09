using Data.Domain.Entities;
using System;
using System.Collections.Generic;
using Data.Persistence;
using System.Linq;

namespace Business.Business.StockRecordRepo
{
    public class StockRecordRepository : IStockRecord
    {
        private readonly IDatabaseContext _databaseService;

        public void Add(StockRecord stock)
        {
            _databaseService.StockRecords.Add(stock);
        }

        public void Delete(Guid id)
        {
            var stock = GetById(id);
            _databaseService.StockRecords.Remove(stock);
        }

        public void Edit(StockRecord stock)
        {
            _databaseService.StockRecords.Update(stock);
        }

        public IReadOnlyList<StockRecord> GetAll()
        {
            return _databaseService.StockRecords.ToList();
        }

        public StockRecord GetById(Guid id)
        {
            return _databaseService.StockRecords.FirstOrDefault(s => s.Id == id);
        }
    }
}
