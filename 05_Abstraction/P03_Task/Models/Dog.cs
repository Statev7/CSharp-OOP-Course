namespace P03_Task.Models
{
    public class Dog : Animal
    {
        public Dog(string name, int age) 
            : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Bark!";
        }
    }
}
