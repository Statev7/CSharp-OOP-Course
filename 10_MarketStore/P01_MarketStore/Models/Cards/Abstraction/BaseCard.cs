namespace P01_MarketStore.Models.Cards.Abstraction
{
    using P01_MarketStore.Models.Abstraction;
    using P01_MarketStore.Models.Users.Contracts;

    public abstract class BaseCard : BaseModel
    {
        protected BaseCard(decimal turnover)
            :base()
        {
            this.Turnover = turnover;
            this.CalculateDiscountRate();
        }

        public IUser Owner { get; private set; }

        public decimal Turnover { get; private set; }

        public double DiscountRate { get; protected set; }

        protected abstract void CalculateDiscountRate();
    }
}
