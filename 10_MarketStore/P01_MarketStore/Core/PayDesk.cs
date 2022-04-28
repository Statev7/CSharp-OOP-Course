namespace P01_MarketStore.Core
{
    using System;
    using System.Text;

    using P01_MarketStore.Models.Cards.Abstraction;

    public class PayDesk
    {
        public static void PrintResult(BaseCard card, decimal purchaseValue)
        {
            StringBuilder sb = new StringBuilder();
            double discount = CalculateDiscount(card, purchaseValue);

            sb.AppendLine($"Purchase value: ${purchaseValue:F2}");
            sb.AppendLine($"Discount rate: {card.DiscountRate:F1}%");
            sb.AppendLine($"Discount: ${discount:F2}");
            sb.AppendLine($"Total: ${purchaseValue - (decimal)discount:F2}");

            Console.WriteLine(sb.ToString());
        }

        private static double CalculateDiscount(BaseCard card, decimal purchaseValue)
        {
            double discount = (double)purchaseValue * (card.DiscountRate / 100);

            return discount;
        }
    }
}
