using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public static class Seeding
    {
        public static List<Product> GetProducts =>
            new List<Product>
            {
                new Food("apples", "BrandA", 1.50m, new DateTime(2021, 06, 14)),
                new Beverages("milk", "BrandM", 0.99m, new DateTime(2022, 02, 02)),
                new Clothes("T-shirt", "BrandT", 15.99m, Enums.Size.M, "violet"),
                new Appliances("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 03, 03), 1.125)
            };

        public static Dictionary<Product, double> GetProductsWithQuantity =>
            new Dictionary<Product, double>
            {
                { GetProducts[0], 2.45 },
                { GetProducts[1], 3 },
                { GetProducts[2], 2 },
                { GetProducts[3], 1 },
            };

        public static DateTime DateOfPurchase => 
            new DateTime(2021, 06, 14, 12, 34, 56);        


    }
}
