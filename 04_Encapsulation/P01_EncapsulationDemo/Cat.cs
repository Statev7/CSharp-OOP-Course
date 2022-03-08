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

    }
}
