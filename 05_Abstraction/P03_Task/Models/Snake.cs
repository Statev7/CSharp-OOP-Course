namespace P03_Task.Models
{
    internal class Snake : Reptile
    {
        public Snake(string name, int age) 
            : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Sss!";
        }
    }
}
