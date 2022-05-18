using System;

namespace Zaddom5_kredek
{
    class Program
    {
        static Vehicle[] vehicle = new Vehicle[3];

        static void InitVehicles()
        {
            vehicle[0] = new Car();
            vehicle[1] = new Car(5, "black", 2017, "Jeep", "SUV", new Gearbox("automatic"));
            vehicle[2] = new Bus(120, "red-yellow", 2013, "Solaris");

            Menu();
        }

        static void Modify(int i)
        {
            i = -1;
        }

        static void Menu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("[1] - Choose an vehicle: ");
            Console.WriteLine("[0] - Exit. ");

            int input = Int32.Parse(Console.ReadLine());

            if (input == 0)
            {
                return;
            }
            else
            {
                PrintAllVehicles();
                input = Int32.Parse(Console.ReadLine());
                Vehicle selectedVehicle = vehicle[input - 1];
                VehicleSpecificMenu();
                input = Int32.Parse(Console.ReadLine());
                ParseVehicle(selectedVehicle, input);
            }
        }

        static void ParseVehicle(Vehicle vehicle, int option)
        {
            if (option == 1)
            {
                Console.WriteLine(vehicle.GetCarmake());
            }
            else
            {
                Sprayer.Changecolor(vehicle, "green");
            }
            Menu();
        }

        static void VehicleSpecificMenu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("[1] - Print car make: ");
            Console.WriteLine("[2] - Send to sprayer: ");
            Console.WriteLine("[0] - Exit. ");
        }

        static void PrintAllVehicles()
        {
            for (int i = 0; i < vehicle.Length; i++)
            {
                Console.WriteLine(vehicle[i].ReturnString());
            }
        }

        static void Main(string[] args)
        {
            InitVehicles();

        }
        
    }
}
