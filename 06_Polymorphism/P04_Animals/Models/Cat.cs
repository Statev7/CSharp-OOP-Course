namespace P04_Animals.Models
{
    using P04_Animals.Models.BaseModel;

    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {

        }

        public override string ExplainSelf()
        {
            string message = $"{base.ExplainSelf()} meoww!";
            return message;
        }
    }
}
