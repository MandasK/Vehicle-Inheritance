using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero bike whizzes silently passed.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero bike turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero bike stops, before a Ram hits it.");
        }
    }
}