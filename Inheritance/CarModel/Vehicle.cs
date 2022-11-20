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
            Console.WriteLine("Masinin ilini daxil edin");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year!=2022)
            {
                Console.WriteLine("Ili sehv daxi etmisiniz");
            }
            return ($"{Color} {Year}");
        }

    }
}
