using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.CarModel;
namespace Inheritance.CarModel
{
    internal class Car:Vehicle
    {
        //public string Brand;
        //public string Model;
        //public byte FuelCapacity;
        //public byte FuelFor1Km;
        //public byte CurrentFuel;
        int GedeBileceyiyol_max = 0;
        byte KmUcunYanacaq = 0;
        public string ShowInfo()
        {
            Console.WriteLine("Markasini qeyd edin");
            string Brand = Console.ReadLine();
            Console.WriteLine("Modelini qeyd edin");
            string Model = Console.ReadLine();
            Console.WriteLine("Yanacaq tutumunu qeyd edin");
            byte FuelCapacity = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("1km ucun ne qeder yanacaq yadirdigini qeyd edin");
            byte FuelFor1Km = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Yanacagin qiymetini qeyd edin");
            byte CurrentFuel = Convert.ToByte(Console.ReadLine());
            GedeBileceyiyol_max = FuelCapacity / FuelFor1Km;
            KmUcunYanacaq = FuelFor1Km;
            if(Brand!= "Land Rover" && Model != "Range Rover" && FuelCapacity != 80 && FuelFor1Km != 1 && CurrentFuel != 2)
            {
                Console.WriteLine("Melimatlardan biri sehvdir");
            }
            return ($"{Brand} - {Model} - {FuelCapacity} litr -{FuelFor1Km} litr -{CurrentFuel} Manat");
        }
        
        public string DriveInfo()
        {
            Console.WriteLine("Gedeceyi yolu teyin edin");
            int Gedeceyiyol = Convert.ToInt32(Console.ReadLine());
            if (GedeBileceyiyol_max > Gedeceyiyol)
            { 
                int QalanBenzin = (GedeBileceyiyol_max - Gedeceyiyol)*KmUcunYanacaq;
                return ($"{QalanBenzin} litr benzin qalacaq");
            }
            else
            {
                return "Yolu tam gede bilmeyecek";
            }

        }

    }
}
