namespace P01_AsynchronousProgramming_Demo.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using P01_AsynchronousProgramming_Demo.Core.Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            Task.Run(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

            }).GetAwaiter().GetResult();

            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            CreateAsync().GetAwaiter().GetResult();
        }

        public async Task<bool> CreateAsync()
        {
            // await this.DbSet.AddAsync(cat);

            return false;
        }
    }
}
