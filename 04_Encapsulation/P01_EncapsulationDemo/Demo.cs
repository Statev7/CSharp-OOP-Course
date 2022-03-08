using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_EncapsulationDemo
{
    public class Demo : Cat
    {
        public Demo(string name, int age) 
            : base(name, age)
        {
        }

    }
}
