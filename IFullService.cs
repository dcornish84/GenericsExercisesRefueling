using System.Collections.Generic;

namespace RefuelingGary
{
    public interface IFullService<T>
    {
        int Capacity { get; set; }

        public void Refuel(List<T> vehicles);
    }
}