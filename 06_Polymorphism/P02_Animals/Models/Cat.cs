namespace P02_Animals.Models
{
    using System;

    using P02_Animals.Models.BaseModel;

    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            string message = base.ExplainSelf() + ' ' + "Meoww!";
            return message;
        }
    }
}
