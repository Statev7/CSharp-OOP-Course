namespace P03_RawData2.Models
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
    }
}
