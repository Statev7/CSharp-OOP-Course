using P01_Zoo.Models.BaseModel;

namespace P01_Zoo.Models.Contracts
{
    public interface IZoo
    {
        void Add(Animal animal);

        string Remove(string type, string name);

        string Report(string type, int age);
    }
}
