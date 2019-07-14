using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my factory!");

            VehicleFactory factory = new VehicleFactory();

            int numberOfWheels = 0;

            Console.Write("Enter number of wheels: ");
            numberOfWheels = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter special data: ");
            string specialData = Console.ReadLine();

            while (numberOfWheels > -1)
            {

                Vehicle newVehicle = factory.CreateVehicle("Honda", 2000, "red", numberOfWheels, specialData);

                Console.WriteLine(newVehicle);

                Console.Write("Enter number of wheels: ");
                numberOfWheels = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter special data: ");
                specialData = Console.ReadLine();
            }

            Console.WriteLine("Good bye!");

            Console.ReadLine();

        }
    }
}