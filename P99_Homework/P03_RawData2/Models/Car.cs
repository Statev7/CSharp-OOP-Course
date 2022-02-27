namespace P03_RawData2.Models
{
    public class Car
    {
        public Car(string model, CarEngine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public string Model { get; set; }

        public CarEngine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }
    }
}
