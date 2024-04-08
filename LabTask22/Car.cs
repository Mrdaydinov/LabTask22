using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask22
{
    internal class Car : Vehicle
    {
        public int FuelCapacity { get; set; }

        public Car(string brand, string model, double millage, int fuelCapacity, int fuel) : base(brand, model, millage, fuel)
        {
            FuelCapacity = fuelCapacity;
        }

        public bool AddFuel(int fuel)
        {
            if (CurrentFuel + fuel <= FuelCapacity)
            {
                CurrentFuel += fuel;
                return true;
            }
            else
                return false;
        }
    }
}
