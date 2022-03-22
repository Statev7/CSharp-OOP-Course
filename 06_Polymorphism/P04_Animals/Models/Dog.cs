namespace P04_Animals.Models
{
    using P04_Animals.Models.BaseModel;

    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {

        }

        //public override string ExplainSelf()
        //{
        //    string message = $"{base.ExplainSelf()} bark!";
        //    return message;
        //}
    }
}
