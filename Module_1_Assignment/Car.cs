using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_1_Assignment
{
    //Task 1: Create a Car Class
    internal class Car
    {
        //Step 1. Create properties of Car Class:
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //Step 2. Add a method called Drive
        public void Drive(int kilometers)
        {
            Mileage += kilometers;
            Console.WriteLine($"Car {Brand} {Model} has driven {kilometers} km. Total mileage: {Mileage} km.");
        }

        // Task 3: Add the ShowCarInfo method
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage}");
        }    

    }
}
