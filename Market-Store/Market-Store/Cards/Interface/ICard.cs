using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Cards.Interface
{
    public interface ICard
    {
        double Turnover { get; }

        double PurchaseValue { get; }

        void PrintPurchaseValue();

        void PrintDiscountRate();

        void PrintDiscountPrice();

        void PrintTotalPrice();
    }
}
