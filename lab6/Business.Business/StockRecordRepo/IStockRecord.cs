using Data.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Business.Business.StockRecordRepo
{
    public interface IStockRecord
    {
        IReadOnlyList<StockRecord> GetAll();
        StockRecord GetById(Guid id);
        void Add(StockRecord stock);
        void Edit(StockRecord stock);
        void Delete(Guid id);
    }
}
