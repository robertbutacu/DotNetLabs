using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ProductData
    {
        private ProductData(){}

        public Guid Id { get; private set; }

        [Required]
        [StringLength(20)]
        public string Name { get; private set; }

        [Required]
        [StringLength(20)]
        public double Price { get; private set; }

        public DateTime Date { get; private set; }

        public static ProductData Create(string name, double code, DateTime date)
        {
            var instance = new ProductData { Id = new Guid() };

            instance.Update(name, code, date);

            return instance;
        }

        public void Update(string name, double price, DateTime date)
        {
            Name = name;

            Price = price;

            Date = date;
        }
    }
}
