using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Domain.Entities
{
    public class StockRecord
    {
        private StockRecord()
        {

        }

        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        [Range(1, double.MaxValue)]
        public Double StartPrice { get; private set; }

        [Range(1, double.MaxValue)]
        public Double EndPrice { get; private set; }

        public static StockRecord Create(Double startPrice, Double endPrice)
        {
            var instance = new StockRecord { Id = new Guid() };

            instance.Update(startPrice, endPrice);

            return instance;

        }

        public void Update(Double startPrice, Double endPrice)
        {
            StartPrice = startPrice;
            EndPrice = endPrice;
        }
    }
}