using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_AbstractionDemo
{
    public class ZooTwo : IZoo
    {
        public void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public void FindAnimalByName(string animalName)
        {
            throw new NotImplementedException();
        }
    }
}
