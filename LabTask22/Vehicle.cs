using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace LabTask22
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Millage { get; set; }
        public int CurrentFuel {  get; set; }

        public Vehicle(string brand, string model, double millage, int fuel)
        {
            Brand = brand;
            Model = model;
            Millage = millage;
            CurrentFuel = fuel;
        }
    }
}
