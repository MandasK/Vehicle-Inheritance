using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "purple";
            Tesla modelS = new Tesla();
            modelS.MainColor = "red";
            Cessna mx410 = new Cessna();
            mx410.MainColor = "white";
            Ram truck = new Ram();
            truck.MainColor = "black";

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            truck.Drive();

            fxs.Turn("left");
            modelS.Turn("left");
            mx410.Turn("right");
            truck.Turn("into ditch");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            truck.Stop();
        }
    }
}