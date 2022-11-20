using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Inheritance.CarModel;
namespace Inheritance.CarModel
{
    internal class Vehicle
    {
        //public string Color;
        //public int Year;     
            public string ShowInfo()
        {
            Console.WriteLine("Masinin rengini daxil edin");
            string Color = Console.ReadLine();
            while(Color != "Black");
            {
                Console.WriteLine("Reng sehvdir");
                Color = Console.ReadLine();
            }
            Console.WriteLine("Masinin ilini daxil edin");
            int Year = Convert.ToInt32(Console.ReadLine());
            while (Year<=2022 && Year>=1900)
            {
                Console.WriteLine("Ili sehv daxi etmisiniz");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            return ($"{Color} {Year}");
        }

    }
}
