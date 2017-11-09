using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.DTO
{
    public class CreateStockRecord
    {
        public DateTime Date { get; set; }

        public Double StartPrice { get; set; }

        public Double EndPrice { get; set; }
    }
}
