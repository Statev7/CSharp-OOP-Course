namespace P02_RawData.Models
{
    public class CarEngine
    {
        public CarEngine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; set; }

        public int Power { get; set; }

        public override string ToString()
        {
            return $"{this.Speed} {this.Power}";
        }
    }
}
