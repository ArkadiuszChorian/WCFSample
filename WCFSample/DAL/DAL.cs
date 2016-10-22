using System;
using System.Collections.Generic;
using Models;

namespace DAL
{
    class DAL
    {
        private static readonly Lazy<DAL> Lazy = new Lazy<DAL>(() => new DAL());
        public static DAL Instance => Lazy.Value;

        private DAL()
        {
            GenerateExampleData();
        }

        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        private void GenerateExampleData()
        {
            for (var i = 0; i < 5; i++)
            {
                Customers.Add(new Customer
                {
                    Id = new Guid(),
                    FullName = "Klient " + i
                });

                Products.Add(new Product
                {
                    Id = i,
                    Name = "Produkt " + i,
                    Description = "To jest produkt numer " + i
                });
            }
        }
    }
}
