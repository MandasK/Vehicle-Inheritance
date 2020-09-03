using System;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram truck gets stuck in the mud.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram stops, sorta.");
        }
    }
}