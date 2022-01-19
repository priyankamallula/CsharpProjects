using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lp = new Laptop();
            lp.ShowDetails(Laptop.Lenovo, Laptop.Price1000, Laptop.i3, Laptop.Ram2GB);
            

            Console.ReadKey();
        }

    }
    class Laptop : LaptopBase
    {
         public void ShowDetails(string name, string price, string processor, string ram)
        {
            Console.WriteLine("Laptop Name : " + name);
           Console.WriteLine("Laptop Price : " + price);
            Console.WriteLine("Laptop Processor : " + processor);
            Console.WriteLine("Laptop Ram :" + ram);
        }
    }
    class LaptopBase
    {
        public const string i3 = "i3";

        public const string Ram2GB = "2GB";

        public const string Price1000 = "$1000";

        public const string Lenovo = "Lenovo";
    }
    
}
