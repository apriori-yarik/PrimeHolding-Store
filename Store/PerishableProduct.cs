using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class PerishableProduct : Product
    {
        public DateTime ExpirationDate { get; set; }

        public PerishableProduct(string name, string brand, decimal price, DateTime expirationDate)
            : base(name, brand, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public override int GetDiscountPercentage(DateTime dateOfPurchase) 
        {
            string expirationDateStr = this.ExpirationDate.ToString("yyyy-MM-dd");
            string dateOfPurchaseStr = dateOfPurchase.ToString("yyyy-MM-dd");

            if (expirationDateStr == dateOfPurchaseStr)
            {
                return 50;
            }
            else if ((this.ExpirationDate - dateOfPurchase).TotalDays <= 5)
            {
                return 10;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Brand}";
        }
    }
}
