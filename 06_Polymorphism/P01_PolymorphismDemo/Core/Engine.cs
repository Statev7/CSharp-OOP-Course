namespace P01_PolymorphismDemo.Core
{
    using System;

    using P01_PolymorphismDemo.Core.Contracts;

    class Engine : IEngine
    {
        public void Run()
        {
            Console.WriteLine("Hello form Engine!");
        }
    }
}
