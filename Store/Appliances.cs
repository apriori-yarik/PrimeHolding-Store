using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Appliances : Product
    {
        public string Model { get; set; }

        public DateTime ProductionDate { get; set; }

        public double Weight { get; set; }

        public Appliances(string name, string brand, decimal price, 
            string model, DateTime productionDate, double weight)
            : base(name, brand, price)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public override int GetDiscountPercentage(DateTime dateOfPurchase)
        {
            var day = dateOfPurchase.DayOfWeek;

            if ((day == DayOfWeek.Sunday || day == DayOfWeek.Saturday)
                && this.Price > 999)
            {
                return 5;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Brand} {this.Model}";
        }
    }
}
