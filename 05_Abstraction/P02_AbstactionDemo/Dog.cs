using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_AbstactionDemo
{
    public class Dog : Animal
    {
        public Dog(string name, int age) 
            : base(name, age)
        {
        }

        public override string MakeSound()
        {
            int a = 5 + 5;
            return $"Bark!! {a}";
        }
    }
}
