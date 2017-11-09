using System;

namespace Data.Domain.Entities
{
    public class StockRecord
    {
        private StockRecord()
        {

        }

        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        public Double StartPrice { get; private set; }

        public Double EndPrice { get; private set; }

        public static StockRecord Create(Double startPrice, Double endPrice)
        {
            if (startPrice < 0 || endPrice < 0)
                throw new ArgumentException("Illegal input");

            var instance = new StockRecord { Id = new Guid() };

            instance.Update(startPrice, endPrice);

            return instance;

        }

        public void Update(Double startPrice, Double endPrice)
        {
            if (startPrice < 0 || endPrice < 0)
                throw new ArgumentException("Illegal input");

            StartPrice = startPrice;
            EndPrice = endPrice;
        }
    }
}