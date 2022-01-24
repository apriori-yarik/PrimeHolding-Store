using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cart
    {
        public Dictionary<Product, double> Items { get; set; }

        public Cart(Dictionary<Product, double> items)
        {
            this.Items = items;
        }
    }
}
