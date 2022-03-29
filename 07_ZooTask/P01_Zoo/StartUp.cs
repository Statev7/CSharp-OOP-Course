namespace P01_Zoo
{
    using System;

    using P01_Zoo.Core;
    using P01_Zoo.Core.Contracts;
    using P01_Zoo.Models;
    using P01_Zoo.Models.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
