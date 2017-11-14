using System;

namespace Presentation.DTO
{
    public class CreateStockRecord
    {
        public DateTime Date { get; set; }

        public Double StartPrice { get; set; }

        public Double EndPrice { get; set; }

        public String Owner { get; set; }
    }
}
