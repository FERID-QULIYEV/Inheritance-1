using System.Drawing;
using System.Reflection;

namespace Inheritance.CarModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car { Brand = "Land Rover" , Model = "Range Rover" ,FuelCapacity =80 , FuelFor1Km=1, CurrentFuel= 2 };
            Car car = new Car();
            //Vehicle vehicle= new Vehicle { Color = "Black" , Year=2020};
            Vehicle vehicle = new Vehicle();
            Console.WriteLine(car.ShowInfo());
            Console.WriteLine(vehicle.ShowInfo());
            Console.WriteLine(car.DriveInfo());
        }
    }
}