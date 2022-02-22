using System.Text;

namespace P02_CarSalesman
{
    public class Car
    {
        public Car(string model, CarEngine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, CarEngine engine, double weight)
            :this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, CarEngine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, CarEngine engine, double weight, string color)
            : this(model, engine, weight)
        {
            this.Color = color;
        }

        public string Model { get; set; }

        public CarEngine Engine { get; set; }

        public double Weight  { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            //          { CarModel}:
            //{ EngineModel}:
            //  Power: { EnginePower}
            //      Displacement: { EngineDisplacement} n/a
            //      Efficiency: { EngineEfficiency} n/a
            //      Weight: { CarWeight} n/a
            //      Color: { CarColor} n/a

            string weight = this.Weight == 0 ? "n/a" : this.Weight.ToString();
            string color = this.Color == null ? "n/a" : this.Color;
            string displacement = this.Engine.Displacement == 0 ? "n/a" : this.Engine.Displacement.ToString();
            string efficiency = this.Engine.Efficiency == null ? "n/a" : this.Engine.Efficiency;

            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($" {this.Engine.Model}:");
            sb.AppendLine($" Power: {this.Engine.Power}");
            sb.AppendLine($" Displacement: {displacement}");
            sb.AppendLine($" Efficiency: {efficiency}");
            sb.AppendLine($" Weight: {weight}");
            sb.AppendLine($" Color: {color}");

            return sb.ToString().TrimEnd(); // 
        }
    }
}
