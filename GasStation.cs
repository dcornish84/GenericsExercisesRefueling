using System;
using System.Collections.Generic;

namespace RefuelingGary
{

    public class GasStation : IFullService<GasPower>
    {
        public int Capacity { get; set; }

        public void Refuel(List<GasPower> vehicles)
        {
            foreach (GasPower vehicle in vehicles)
            {
                vehicle.FuelLevel = 100;
                Console.WriteLine($"{vehicle.Name} tank is full, ready to roll!");
            }
        }
    }
}