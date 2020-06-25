using Market_Store.Cards.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Cards
{
    public class BronzeCard : ICard
    {   
        public BronzeCard(double turnover, double purchaseValue)
        {
            this.Turnover = turnover;
            this.PurchaseValue = purchaseValue;
        }

        public double Turnover { get; private set; }

        public double PurchaseValue { get; private set; }

        private double discountRate;

        private double totalPrice;

        private double discountPrice;

        public void PrintPurchaseValue()
        {
            Console.WriteLine($"Purchase value: ${this.PurchaseValue:f2}");
        }

        public void PrintDiscountRate()
        {
            if (this.Turnover < 100)
            {
                discountRate = 0.00;
            }
            else if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                discountRate = 1.00;
            }
            else
            {
                discountRate = 2.5;
            }

            Console.WriteLine($"Discount rate: {discountRate:F1}%");
        }

        public void PrintDiscountPrice ()
        {
            if (this.Turnover < 100)
            {
                discountRate = 0.00;
            }
            else if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                discountRate = 1.00;
            }
            else
            {
                discountRate = 2.5;
            }

            discountPrice = this.PurchaseValue * (discountRate / 100);
            Console.WriteLine($"Discount: ${discountPrice:F2}");
        }

        public void PrintTotalPrice ()
        {
            if (this.Turnover < 100)
            {
                discountRate = 0.00;
            }
            else if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                discountRate = 1.00;
            }
            else
            {
                discountRate = 2.5;
            }

            discountPrice = this.PurchaseValue * (discountRate / 100);

            totalPrice = this.PurchaseValue - discountPrice;
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
