using System;

namespace Garage
{

    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies overhead.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna bike turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna Lands safely.");
        }
    }
}