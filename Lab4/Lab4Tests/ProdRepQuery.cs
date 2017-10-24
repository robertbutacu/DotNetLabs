using Lab4;
using System;
using System.Collections.Generic;
using Xunit;

namespace Lab4Tests
{
    public class ProdRepQuery
    {
        public IEnumerable<Product> Products { get; private set; }

        public ProdRepQuery()
        {
            Products = new List<Product>()
            {
               new Product("A", "B", new DateTime(2017, 10, 24), new DateTime(2017, 10, 25), 100.0),
               new Product("C", "C", new DateTime(2017, 10, 20), new DateTime(2017, 10, 30), 120.0),
               new Product("D", "D", new DateTime(2017, 10, 27), new DateTime(2017, 10, 30), 130.0),
               new Product("E", "E", new DateTime(2017, 10, 21), new DateTime(2017, 10, 24), 130.0),
               new Product("F", "BF", new DateTime(2017, 10, 23), new DateTime(2017, 10, 26), 10.0),
               new Product("G", "BG", new DateTime(2017, 10, 22), new DateTime(2017, 10, 27), 1010.0),
               new Product("H", "BH", new DateTime(2017, 10, 25), new DateTime(2017, 10, 29), 5.0),
               new Product("I", "BJ", new DateTime(2017, 10, 5), new DateTime(2017, 10, 30), 180.0),
               new Product("J", "BK", new DateTime(2017, 10, 21), new DateTime(2017, 10, 28), 20.0),
               new Product("K", "BL", new DateTime(2017, 10, 24), new DateTime(2017, 10, 25), 1200.0)
            };
        }

        [Fact]
        public void ShouldRetrieveActiveProducts()
        {
        }
    }
}
