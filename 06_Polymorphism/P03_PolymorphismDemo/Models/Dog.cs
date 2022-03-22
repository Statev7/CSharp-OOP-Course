namespace P03_PolymorphismDemo.Models
{
    using P03_PolymorphismDemo.Models.BaseModel;

    public class Dog : Animal
    {
        public Dog(string name, int age) 
            : base(name, age)
        {
        }
    }
}
