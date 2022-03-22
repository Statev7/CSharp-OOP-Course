namespace P01_PolymorphismDemo.Models
{
    using P01_PolymorphismDemo.Models.BaseModel;

    public class Snake : Animal
    {
        public Snake(string name, int age) 
            : base(name, age)
        {
        }

        public override string MakeSound()
        {
            throw new System.NotImplementedException();
        }
    }
}
