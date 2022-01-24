using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string brand, decimal price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }

        public abstract int GetDiscountPercentage(DateTime dateOfPurchase);

        public abstract override string ToString();
    }
}
