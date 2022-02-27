namespace P01_BasicOOP.Models
{
    using System.Text;

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HoursePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HoursePower { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Type: {this.Type}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Horsepower: {this.HoursePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
