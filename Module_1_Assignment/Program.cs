using System.Collections.Generic;
using System.Reflection;
using System.Security.Claims;

namespace Module_1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2: Create Objects of the Class
            //Create two different Car objects(e.g., Toyota, Tesla).

            Car toyotaCorolla = new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2020,
                Mileage = 0
            };
            Car teslaModel3 = new Car
            {
                Brand = "Tesla",
                Model = "Model 3",
                Year = 2021,
                Mileage = 0
            };

            ///Step 2. Call the Drive method on both cars(different kilometers for each).Expected Output(Example):
            toyotaCorolla.Drive(50); // Car Toyota Corolla has driven 50 km. Total mileage: 50 km.
            teslaModel3.Drive(120); // Car Tesla Model 3 has driven 120 km. Total mileage: 120 km.
            toyotaCorolla.Drive(30); // Car Toyota Corolla has driven 30 km. Total mileage: 80 km.


            // Now we can call the new ShowCarInfo() method on each object
            Console.WriteLine("\nDisplaying final car information:");
            toyotaCorolla.ShowCarInfo(); 
            teslaModel3.ShowCarInfo();   


        }
    }
}
