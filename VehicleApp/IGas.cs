using System;

namespace Garage
{
    public interface IGas
    {
        double CurrentTankPercentage { get; }
        void RefuelTank();
    }
}