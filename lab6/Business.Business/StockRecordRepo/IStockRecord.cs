using Data.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Business.StockRecordRepo
{
    public interface IStockRecord
    {
        IReadOnlyList<StockRecord> GetAll();
        StockRecord GetById(Guid id);
        void Add(StockRecord todo);
        void Edit(StockRecord todo);
        void Delete(Guid id);
    }
}
