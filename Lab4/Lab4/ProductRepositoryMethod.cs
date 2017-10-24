using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab4
{
    public class ProductRepositoryMethod
    {
        public IEnumerable<Product> Products { get; private set; }

        public ProductRepositoryMethod(IEnumerable<Product> products)
        {
            Products = products;
        }

        public IQueryable<Product> RetriveActiveProducts()
        {
            var activeProducts = Products.Where(p => p.EndDate.CompareTo(DateTime.Now) < 0);
            return activeProducts.AsQueryable();
        }

        public IQueryable<Product> RetriveInactiveProducts()
        {
            return Products.Where(p => p.EndDate.CompareTo(DateTime.Now) < 0).AsQueryable();
        }

        public IQueryable<Product> RetriveAllOrderByPriceDescending()
        {
            return Products.OrderByDescending(p => p.Price).AsQueryable();
        }

        public IQueryable<Product> RetriveAllOrderByPriceAscending()
        {
            return Products.OrderBy(p => p.Price).AsQueryable();
        }

        public IQueryable<Product> RetriveAll(String name)
        {
            return Products.Where(p => p.ProductName == name).AsQueryable();
        }

        public IQueryable<Product> RetriveAll(DateTime startDate, DateTime endDate)
        {
            return Products.Where( p => p.StartDate.CompareTo(startDate) >= 0 &&
                                 p.EndDate.CompareTo(endDate) <= 0).AsQueryable();
        }
    }
}
}
