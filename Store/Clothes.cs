using Store.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Clothes : Product
    {
        public Size Size { get; set; }
        public string Color { get; set; }

        public Clothes(string name, string brand, decimal price, Size size, string color)
            : base(name, brand, price)
        {
            this.Color = color;
            this.Size = size;
        }

        public override int GetDiscountPercentage(DateTime dateOfPurchase)
        {
            var day = dateOfPurchase.DayOfWeek;

            if (day == DayOfWeek.Monday
                || day == DayOfWeek.Tuesday
                || day == DayOfWeek.Wednesday
                || day == DayOfWeek.Thursday
                || day == DayOfWeek.Friday)
            {
                return 10;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Brand} {this.Size} {this.Color}";
        }
    }
}
