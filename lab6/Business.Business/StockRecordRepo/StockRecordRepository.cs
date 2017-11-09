using Data.Domain.Entities;
using System;
using System.Collections.Generic;
using Data.Persistence;
using System.Linq;

namespace Business.Business.StockRecordRepo
{
    public class StockRecordRepository : IStockRecord
    {
        private readonly IDatabaseContext _databaseservice;

        public void Add(StockRecord stock)
        {
            _databaseservice.StockRecords.Add(stock);
        }

        public void Delete(Guid id)
        {
            var stock = GetById(id);
            _databaseservice.StockRecords.Remove(stock);
        }

        public void Edit(StockRecord stock)
        {
            _databaseservice.StockRecords.Update(stock);
        }

        public IReadOnlyList<StockRecord> GetAll()
        {
            return _databaseservice.StockRecords.ToList();
        }

        public StockRecord GetById(Guid id)
        {
            return _databaseservice.StockRecords.FirstOrDefault(s => s.Id == id);
        }
    }
}
