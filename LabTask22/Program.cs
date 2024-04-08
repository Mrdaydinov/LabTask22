using System.Reflection.Emit;

namespace LabTask22
{
    internal class Program
    {
        static void Main(string[] args)
        {
        brandInput:
            Console.WriteLine("Enter brand");
            string brand = Console.ReadLine();
            if (brand == null)
                goto brandInput;

            modelInput:
            Console.WriteLine("Enter model");
            string model = Console.ReadLine();
            if (model == null)
                goto modelInput;

            millageInput:
            Console.WriteLine("Enter millage");
            bool flag = double.TryParse(Console.ReadLine(), out double millage);
            if (!flag)
                goto millageInput;

            fuelCapacityInput:
            Console.WriteLine("Enter Fuel Capacity");
            bool flag1 = int.TryParse(Console.ReadLine(), out int fuelCapacity);
            if (!flag1)
                goto fuelCapacityInput;

            fuelInput:
            Console.WriteLine("Enter Current Fuel");
            bool flag2 = int.TryParse(Console.ReadLine(), out int currentFuel);
            if (!flag2)
                goto fuelInput;


            Car car = new(brand, model, millage, fuelCapacity, currentFuel);

        checkSpace:

            bool res = int.TryParse(Console.ReadLine(), out int newFuel);
            if (res == false)
                goto checkSpace;

            
            if (car.AddFuel(newFuel) == false)
                goto checkSpace;
            Console.WriteLine(car.CurrentFuel);
        }
    }
}
