using P03_PolymorphismDemo.Models.BaseModel;

namespace P03_PolymorphismDemo.Models
{
    public class Snake : Animal
    {
        public Snake(string name, int age) 
            : base(name, age)
        {
        }
    }
}
