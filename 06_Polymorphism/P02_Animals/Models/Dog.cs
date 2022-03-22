namespace P02_Animals.Models
{
    using P02_Animals.Models.BaseModel;

    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            string message = $"{base.ExplainSelf()}, Bark!!";
            return message;
        }
    }
}
