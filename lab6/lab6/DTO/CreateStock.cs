using Data.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Presentation.DTO
{
    public class CreateStock
    {
        public String Name { get; set; }

        public String Code { get; set; }

        public List<StockRecord> StockRecords { get; set; }
    }
}
