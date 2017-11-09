using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain.Entities
{
    class StockModel
    {

        private StockModel()
        {

        }
    
        public Guid Id { get; private set; }

        public String Name { get; private set; }

        public String Code { get; private set; }

        public List<StockRecord> StockRecords { get; private set; }

        public static StockModel Create(String name, String code, List<StockRecord> stockRecords)
        {
            if (name.Length <= 0 && code.Length <= 0)
                throw new ArgumentException("Invalid input");

            var instance = new StockModel { Id = new Guid() };

            instance.Update(name, code, stockRecords);

            return instance;

        }

        public void Update(String name, String code, List<StockRecord> stockRecords)
        {
            if (name.Length <= 0 && code.Length <= 0)
                throw new ArgumentException("Invalid input");

            Name = name;

            Code = code;

            StockRecords = stockRecords;
        }

    }
}
