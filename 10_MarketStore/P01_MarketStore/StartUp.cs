namespace P01_MarketStore
{
    using P01_MarketStore.Core;
    using P01_MarketStore.Core.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
