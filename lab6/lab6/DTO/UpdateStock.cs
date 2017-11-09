using Data.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.DTO
{
    public class UpdateStock
    {
        public String Name { get; set; }

        public String Code { get; set; }

        public List<StockRecord> StockRecords { get; set; }
    }
}
