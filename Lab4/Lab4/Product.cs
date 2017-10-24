using System;

namespace Lab4
{
    /*
     *Product
        Id
        ProductName (max 50)
        ProductDescription(max 200)
        StartDate
        EndDate
        Price (double) 
     * 
     */
    public class Product
    {
        public Guid Id { get; private set; }
        public String ProductName { get; private set; }
        public String ProductDescription { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Price { get; private set; }


        public Product(String productName, String productDescription, DateTime startDate, DateTime endDate, double price)
        {
            if (IsValid(productName, productDescription, startDate, endDate, price))
            {
                Id = Guid.NewGuid();
                ProductName = productName;
                ProductDescription = productDescription;
                StartDate = startDate;
                EndDate = endDate;
                Price = price;
            }
            else throw new ArgumentException("Invalid arguments!");
        }

        private Boolean IsValid(String productName, String productDescription, DateTime startDate, DateTime endDate, double price)
        {
            return IsValidLength(productName, 50) && IsValidLength(productName, 200)
                && IsValidDates(startDate, endDate) && IsValidPrice(price);
        }

        private Boolean IsValidLength(String input, int maxLength)
        {
            return input.Length < maxLength;
        }

        private Boolean IsValidDates(DateTime startDate, DateTime endDate)
        {
            return startDate.CompareTo(EndDate) < 0;
        }

        private Boolean IsValidPrice(double price)
        {
            return price >= 0.0;
        }
    }
}
