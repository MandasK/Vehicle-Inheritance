using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zooms by.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla stops, without you hittingthe brakes.");
        }
    }
}