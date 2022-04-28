namespace P01_MarketStore.Core
{
    using System;
    using System.Linq;

    using P01_MarketStore.Core.Contracts;
    using P01_MarketStore.Models.Cards;
    using P01_MarketStore.Models.Cards.Abstraction;

    public class Engine : IEngine
    {
        public void Run()
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string cardType = tokens[0].ToLower();
            decimal turnover = decimal.Parse(tokens[1]);
            decimal purchaseValue = decimal.Parse(tokens[2]);

            BaseCard card = CreateCard(cardType, turnover);

            PayDesk.PrintResult(card, purchaseValue);   
        }

        private static BaseCard CreateCard(string cardType, decimal turnover)
        {
            BaseCard card = null;

            switch (cardType)
            {
                case "bronze":
                    card = new BronzeCard(turnover);
                    break;
                case "silver":
                    card = new SilverCard(turnover);
                    break;
                case "gold":
                    card = new GoldCard(turnover);
                    break;
            }

            return card;
        }
    }
}
