using System;
using System.Collections.Generic;
using System.Text;
using Data.Domain.Entities;

namespace Business.Business.StockModelRepo
{
    public interface IStockModel
    {
        IReadOnlyList<StockModel> GetAll();
        StockModel GetById(Guid id);
        void Add(StockModel stock);
        void Edit(StockModel stock);
        void Delete(Guid id);
    }
}
