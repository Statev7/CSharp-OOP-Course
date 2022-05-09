namespace P01_AsynchronousProgramming_Demo
{
    using P01_AsynchronousProgramming_Demo.Core;
    using P01_AsynchronousProgramming_Demo.Core.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
