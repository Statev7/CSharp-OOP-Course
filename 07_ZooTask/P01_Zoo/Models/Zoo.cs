namespace P01_Zoo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using P01_Zoo.Constants.Messages;
    using P01_Zoo.Models.BaseModel;
    using P01_Zoo.Models.Contracts;

    public class Zoo : IZoo
    {
        private readonly ICollection<Animal> animals;

        public Zoo()
        {
            this.animals = new List<Animal>();
        }

        public void Add(Animal animal)
        {
            this.animals.Add(animal);
        }

        public string Remove(string type, string name)
        {
            Animal animal = this.animals
                .FirstOrDefault(a => a.GetType().Name.ToLower() == type && a.Name == name);

            if (animal == null)
            {
                string errorMessage = string.Format(ErrorMessages.INVALID_ANIMAL, type);
                throw new ArgumentException(errorMessage);
            }

            this.animals.Remove(animal);

            string message = string.Format(OutputMessages.REMOVED_ANIMAL, type, name);
            return message;
        }

        public string Report(string type, int age)
        {
            List<Animal> animals = this.animals
                .Where(a => a.GetType().Name.ToLower() == type && a.Age >= age)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var animal in animals)
            {
                sb.AppendLine(animal.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
