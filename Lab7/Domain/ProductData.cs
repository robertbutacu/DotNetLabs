using System;

namespace Domain
{
    public class ProductData
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public double Price { get; private set; }

        public DateTime Date { get; private set; }
    }
}
