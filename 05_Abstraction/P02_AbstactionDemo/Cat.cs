namespace P02_AbstactionDemo
{
    public sealed class Cat : Animal
    {
        public Cat(string name, int age) 
            : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Meowwww!";
        }
    }
}
