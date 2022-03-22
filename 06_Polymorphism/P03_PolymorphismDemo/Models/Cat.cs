namespace P03_PolymorphismDemo.Models
{
    using P03_PolymorphismDemo.Models.BaseModel;

    public class Cat : Animal
    {
        public Cat(string name, int age) 
            : base(name, age)
        {
        }

        public void Demo()
        {

        }
    }
}
