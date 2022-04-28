namespace P01_MarketStore.Models.Cards
{
    using P01_MarketStore.Models.Cards.Abstraction;

    public class GoldCard : BaseCard
    {
        public GoldCard(decimal turnover) 
            : base(turnover)
        {

        }

        protected override void CalculateDiscountRate()
        {
            double initialDiscount = 2;

            double bonusDiscount = (double)this.Turnover / 100;
            double totalDiscount = initialDiscount + bonusDiscount;

            if (totalDiscount > 10)
            {
                totalDiscount = 10;
            }

            this.DiscountRate = totalDiscount;
        }
    }
}
