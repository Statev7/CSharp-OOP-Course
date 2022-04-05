namespace P01_GenericDemo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            //var arr = CreateArray<Cat>(new Cat());
            var myCollection = new MyCollection<Cat>();
            myCollection.Add(new Cat());

            //Console.WriteLine(string.Join(" ", arr));
        }

        public static T[] CreateArray<T>(T element)
        {
            T[] arr = new T[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = element;
            }

            return arr;
        }
    }
}
