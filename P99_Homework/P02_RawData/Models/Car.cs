namespace P02_RawData.Models
{
    public class Car
    {
        public Car(string model, CarEngine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public string Model { get; set; }

        public CarEngine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public override string ToString()
        {
            //ChevroletExpress 215 255 1200 flamable

            return $"{this.Model}";
        }
    }
}
