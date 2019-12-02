using System;
using System.Collections.Generic;

namespace RefuelingGary
{
    public class ElectricPower
    {
        public int BatterykWh { get; set; }

        public string Name { get; set; }

        public int BatteryLevel { get; set; }

        public List<ElectricPower> allElectricVehicles = new List<ElectricPower>();

        public ElectricPower(string name, int batteryLevel)
        {
            Name = name;
            BatteryLevel = batteryLevel;
        }

        public void RechargeBattery()
        {
            BatterykWh = 100;
        }

        public void Drive()
        {
            Console.WriteLine("Whooooooosh!");
        }
    }
}