namespace P02_Zoo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }

            int sum = arr.Sum();
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(sum);
            
        }
    }
}
