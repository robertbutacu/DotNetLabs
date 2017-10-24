using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class ProductRepositoryQuery
    {
        public IEnumerable<Product> Products { get; private set; }

        public ProductRepositoryQuery(IEnumerable<Product> products)
        {
            Products = products;
        }

        public IQueryable<Product> RetriveActiveProducts()
        {
            return (from p in Products
                    where p.EndDate.CompareTo(DateTime.Now) > 0
                    select p).AsQueryable();
        }

        public IQueryable<Product> RetriveInactiveProducts()
        {
            return (from p in Products
                                 where p.EndDate.CompareTo(DateTime.Now) < 0
                                 select p).AsQueryable();
        }

        public IQueryable<Product> RetriveAllOrderByPriceDescending()
        {
            return (from p in Products
                                 orderby p.Price descending
                                 select p).AsQueryable();
        }

        public IQueryable<Product> RetriveAllOrderByPriceAscending()
        {
            return (from p in Products
                                 orderby p.Price ascending
                                 select p).AsQueryable();
        }

        public IQueryable<Product> RetriveAll(String name)
        {
            return (from p in Products
                                 where p.ProductName.Contains(name)
                                 select p).AsQueryable();
        }

        public IQueryable<Product> RetriveAll(DateTime startDate, DateTime endDate)
        {
            return (from p in Products
                                 where p.StartDate.CompareTo(startDate) >= 0 &&
                                 p.EndDate.CompareTo(endDate) <= 0
                                 select p).AsQueryable();
        }
    }
}
