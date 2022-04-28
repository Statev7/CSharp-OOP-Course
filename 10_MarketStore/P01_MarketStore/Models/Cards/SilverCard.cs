namespace P01_MarketStore.Models.Cards
{
    using P01_MarketStore.Models.Cards.Abstraction;

    public class SilverCard : BaseCard
    {
        public SilverCard(decimal turnover) 
            : base(turnover)
        {

        }

        protected override void CalculateDiscountRate()
        {
            double discount = 2;

            if (this.Turnover > 300)
            {
                discount = 3.5;
            }

            this.DiscountRate = discount;
        }
    }
}
