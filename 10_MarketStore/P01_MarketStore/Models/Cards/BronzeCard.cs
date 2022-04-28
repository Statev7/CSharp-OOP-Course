namespace P01_MarketStore.Models.Cards
{
    using P01_MarketStore.Models.Cards.Abstraction;

    public class BronzeCard : BaseCard
    {
        public BronzeCard(decimal turnover) 
            : base(turnover)
        {

        }

        protected override void CalculateDiscountRate()
        {
            double discount = 0;

            if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                discount = 1;
            }
            else if(this.Turnover > 300)
            {
                discount = 2.5;
            }

            this.DiscountRate = discount;
        }
    }
}
