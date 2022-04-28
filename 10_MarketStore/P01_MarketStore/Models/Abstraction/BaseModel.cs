namespace P01_MarketStore.Models.Abstraction
{
    using System;

    public abstract class BaseModel
    {
        protected BaseModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
