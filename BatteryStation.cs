using System;
using System.Collections.Generic;

namespace RefuelingGary
{

    public class BatteryStation : IFullService<ElectricPower>
    {
        public int Capacity { get; set; }

        public void Refuel(List<ElectricPower> vehicles)
        {
            foreach (ElectricPower vehicle in vehicles)
            {
                vehicle.BatteryLevel = 100;

                Console.WriteLine($"{vehicle.Name} is fully charged and ready to roll!");
            }
        }
    }
}