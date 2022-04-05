namespace P02_GenericDemo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var list = new MyCollection<Cat>();
            
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
