namespace P01_SpeedRacing
{
    using System;

    public class Car
    {
        private const string INSUFFICIENT_FUEL_ERROR_MESSAGE = "Insufficient fuel for the drive";

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            double neededLitetres = amountOfKm * this.FuelConsumptionPerKilometer;

            if (neededLitetres > this.FuelAmount)
            {
                throw new ArgumentException(INSUFFICIENT_FUEL_ERROR_MESSAGE);
            }

            this.FuelAmount -= neededLitetres;
            this.TravelledDistance += amountOfKm;
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance}";
        }
    }
}
