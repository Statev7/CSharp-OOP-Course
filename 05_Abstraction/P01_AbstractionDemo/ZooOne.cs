using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_AbstractionDemo
{
    public class ZooOne : IZoo
    {
        public void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public void FindAnimalByName(string animalName)
        {
            throw new NotImplementedException();
        }

        public void Test()
        {

        }
    }
}
