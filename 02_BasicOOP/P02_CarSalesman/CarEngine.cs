namespace P02_CarSalesman
{
    public class CarEngine
    {
        public CarEngine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
        }

        public CarEngine(string model, double power, double displacement)
            :this(model, power)
        {
            this.Displacement = displacement;
        }

        public CarEngine(string model, double power, string efficiency)
            :this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public CarEngine(string model, double power, double displacement, string efficiency)
            :this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }

        public double Power { get; set; }

        public double Displacement { get; set; }

        public string Efficiency { get; set; }

    }
}
