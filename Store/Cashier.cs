using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cashier
    {
        public Cart Cart { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public Cashier(Cart cart, DateTime dateOfPurchase)
        {
            this.Cart = cart;
            this.DateOfPurchase = dateOfPurchase;
        }

        public void PrintReceipt()
        {
            string date = this.DateOfPurchase.ToString("yyyy-MM-dd hh:mm:ss");
            decimal subtotal = 0;
            decimal total = 0;

            Console.WriteLine($"Date: {date}");
            Console.WriteLine("---Products---");

            foreach (var item in this.Cart.Items)
            {
                decimal totalPricePerItem = (decimal)item.Value * item.Key.Price;

                Console.WriteLine();
                Console.WriteLine(item.Key.ToString());
                Console.WriteLine($"{item.Value} X ${item.Key.Price} = ${totalPricePerItem:f2}");

                int discount = item.Key.GetDiscountPercentage(this.DateOfPurchase);

                if (discount != 0)
                {
                    decimal totalPriceWithDiscount = totalPricePerItem * (decimal)(1 - discount / 100.0);
                    Console.WriteLine($"#discount {discount}% -${(totalPricePerItem - totalPriceWithDiscount):f2}");
                    total += totalPriceWithDiscount;
                }
                else
                {
                    total += totalPricePerItem;
                }

                subtotal += totalPricePerItem;
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine($"SUBTOTAL: ${subtotal:f2}");
            Console.WriteLine($"DISCOUNT: -${(subtotal - total):f2}");
            Console.WriteLine();
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
