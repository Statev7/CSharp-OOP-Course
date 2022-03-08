using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_EncapsulationDemo
{
    public class Cat
    {
        private int age;

        public Cat(string name, int age)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public int Age => DateTime.UtcNow.Year - 2001;

        public void Test()
        {
            
        }
    }
}
