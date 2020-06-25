using Market_Store.Cards;
using System;

namespace Market_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bronze card data:");

            BronzeCard bronzeCard = new BronzeCard(0, 150);

            bronzeCard.PrintPurchaseValue();
            bronzeCard.PrintDiscountRate();
            bronzeCard.PrintDiscountPrice();
            bronzeCard.PrintTotalPrice();

            Console.WriteLine();
            Console.WriteLine("Silver card data:");

            SilverCard silverCard = new SilverCard(600, 850);

            silverCard.PrintPurchaseValue();
            silverCard.PrintDiscountRate();
            silverCard.PrintDiscountPrice();
            silverCard.PrintTotalPrice();

            Console.WriteLine();
            Console.WriteLine("Gold card data:");

            GoldCard goldCard = new GoldCard(1500, 1300);

            goldCard.PrintPurchaseValue();
            goldCard.PrintDiscountRate();
            goldCard.PrintDiscountPrice();
            goldCard.PrintTotalPrice();

        }
    }
}
