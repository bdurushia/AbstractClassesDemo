using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            Car golfR = new Car()
            {
                Name = "Big Turbo Golf",
                Year = "2017",
                Make = "VW",
                Model = "Golf R",
                HasTrunk = true
            };

            Vehicle suzuGSX = new Motorcycle()
            {
                Name = "Suzuki Cafe Racer",
                Year = "2001",
                Make = "Suzuki",
                Model = "GSX 1400",
                HasSideCart = true
            };

            Vehicle audiRS5 = new Car()
            {
                Name = "Audi Turbo V8",
                Year = "2014",
                Make = "Audi",
                Model = "RS5",
                HasTrunk = true
            };

            Motorcycle yamR3 = new Motorcycle()
            {
                Name = "Yamaha Rocket",
                Year = "2016",
                Make = "Yamaha",
                Model = "R3",
                HasSideCart = false
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehicles.Add(audiRS5);
            vehicles.Add(yamR3);
            vehicles.Add(golfR);
            vehicles.Add(suzuGSX);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("YEAR\t\tMAKE\t\tMODEL");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}\t\t{vehicle.Make}\t\t{vehicle.Model}");
            }

            Console.WriteLine("------------------------------------------------------\n\n");


            // Call each of the drive methods for one car and one motorcycle
            yamR3.DriveAbstract();
            yamR3.DriveVirtual();
            golfR.DriveAbstract();
            golfR.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
