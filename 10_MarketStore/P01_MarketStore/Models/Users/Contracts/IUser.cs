namespace P01_MarketStore.Models.Users.Contracts
{
    public interface IUser
    {
        public string FirstName { get; }

        public string LastName { get; }

        public byte Age { get; }
    }
}
