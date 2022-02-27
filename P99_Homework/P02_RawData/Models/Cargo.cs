namespace P02_RawData.Models
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return $"{this.Weight} {this.Type}";
        }
    }
}
