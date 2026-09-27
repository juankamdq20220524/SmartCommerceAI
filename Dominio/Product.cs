using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCommerceAI.Dominio
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; private set; }

        public Product(string name, string description, decimal price, int stock)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Product name cannot be empty.");
            }

            if(price < 0)
            {
                throw new ArgumentException("Product price cannot be negative.");
            }

            if(stock < 0)
            {
                throw new ArgumentException("Product stock cannot be negative.");
            }

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

    }
}
