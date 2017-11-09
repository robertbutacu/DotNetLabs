using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Domain.Entities
{
    public class StockModel
    {

        private StockModel()
        {

        }
    
        public Guid Id { get; private set; }

        [Required]
        [StringLength(20)]
        public String Name { get; private set; }

        [Required]
        [StringLength(20)]
        public String Code { get; private set; }

        public List<StockRecord> StockRecords { get; private set; }

        public static StockModel Create(String name, String code, List<StockRecord> stockRecords)
        {
            var instance = new StockModel { Id = new Guid() };

            instance.Update(name, code, stockRecords);

            return instance;

        }

        public void Update(String name, String code, List<StockRecord> stockRecords)
        {
            Name = name;

            Code = code;

            StockRecords = stockRecords;
        }

    }
}
