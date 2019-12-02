using System;
using System.Collections.Generic;
using System.Linq;

namespace RefuelingGary
{
    class Program
    {
        static void Main(string[] args)
        {

            GasPower Bronco = new GasPower("1983 Ford Bronco", 39);
            GasPower Ferrari = new GasPower("1961 Ferrari 250 GT", 63);
            GasPower Lambo = new GasPower("1966 Lamborghini Miura", 70);
            GasPower Porsche = new GasPower("1974 Porsche 911", 52);

            ElectricPower Audi = new ElectricPower("2020 Audi e-tron", 91);
            ElectricPower Aston = new ElectricPower("2020 Aston Martin Rapide E", 30);
            ElectricPower Volvo = new ElectricPower("2020 Volvo Polestar 2", 72);
            ElectricPower Tesla = new ElectricPower("2020 Tesla Roadster", 49);

            List<GasPower> gasPowered = new List<GasPower>();
            List<ElectricPower> electricPowered = new List<ElectricPower>();

            electricPowered.Add(Audi);
            electricPowered.Add(Aston);
            electricPowered.Add(Volvo);
            electricPowered.Add(Tesla);
            gasPowered.Add(Bronco);
            gasPowered.Add(Ferrari);
            gasPowered.Add(Lambo);
            gasPowered.Add(Porsche);

            GasStation gasStation = new GasStation();
            BatteryStation batteryStation = new BatteryStation();

            batteryStation.Refuel(electricPowered);
            gasStation.Refuel(gasPowered);
        }
    }
}