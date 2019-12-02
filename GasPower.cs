using System;

namespace RefuelingGary
{
    public class GasPower
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public string Name { get; set; }

        public GasPower(string name, int fuelCapacity)
        {
            Name = name;
            FuelCapacity = fuelCapacity;
        }

        public void Drive()
        {
            Console.WriteLine("ClapClapClapBoom");
        }

        public void Refuel()
        {
            FuelLevel = FuelCapacity;
        }
    }
}