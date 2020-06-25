using Market_Store.Cards.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Cards
{
    class GoldCard : ICard
    {
        public GoldCard(double turnover, double purchaseValue)
        {
            this.Turnover = turnover;
            this.PurchaseValue = purchaseValue;
        }
        public double Turnover { get; private set; }
        public double PurchaseValue { get; private set; }

        private double discountRate = 2;

        private double totalPrice;

        private double discountPrice;

        public void PrintPurchaseValue()
        {
            Console.WriteLine($"Purchase value: ${this.PurchaseValue:f2}");
        }

        public void PrintDiscountRate()
        {
            discountRate += (int)this.Turnover / 100;

            if (discountRate > 10)
            {
                discountRate = 10;
            }

            Console.WriteLine($"Discount rate: {discountRate:F1}%");
        }

        public void PrintDiscountPrice()
        {
            discountRate += (int)this.Turnover / 100;

            if (discountRate > 10)
            {
                discountRate = 10;
            }

            discountPrice = this.PurchaseValue * (discountRate / 100);
            Console.WriteLine($"Discount: ${discountPrice:F2}");
        }

        public void PrintTotalPrice()
        {
            discountRate += (int)this.Turnover / 100;

            if (discountRate > 10)
            {
                discountRate = 10;
            }

            discountPrice = this.PurchaseValue * (discountRate / 100);

            totalPrice = this.PurchaseValue - discountPrice;
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
