namespace P02_AsynchronousProgramming_Demo.Core
{
    using System;
    using System.Threading.Tasks;

    using P02_AsynchronousProgramming_Demo.Core.Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(new string('-', 50));
                }
            }).GetAwaiter().GetResult();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            //CreateAsync().GetAwaiter().GetResult();
        }

        //public async Task CreateAsync()
        //{
        //    //await this.dbSet.Add(cat);
        //} 
    }
}
