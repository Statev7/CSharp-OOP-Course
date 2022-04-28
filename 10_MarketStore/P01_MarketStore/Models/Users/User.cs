namespace P01_MarketStore.Models.Users
{
    using P01_MarketStore.Models.Abstraction;
    using P01_MarketStore.Models.Users.Contracts;

    public class User : BaseModel, IUser
    {
        public User()
            :base()
        {

        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public byte Age { get; private set; }
    }
}
