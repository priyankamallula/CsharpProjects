using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAssemble
{
    class Assemblyline
    { 
        public static void SuccessRate() { }
        public static void ProductionRatePerHour() { }
        public static void WorkingItemsPerMinute() { }

    }
    class Program
    {
        static void Main()
        {
            Assemblyline.SuccessRate();
            Console.Write("Enter Speed:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("SuccessRate =" + 0);
            }
            else if (a == 1 || a == 2 || a == 3 || a == 4)
            {
                Console.WriteLine("SuccessRate = " + 1);
            }
            else if (a == 5 || a == 6 || a == 7 || a == 8)
            {
                Console.WriteLine("SuccessRate= " + 0.9);
            }
            else if (a == 9)
            {
                Console.WriteLine("SuccessRate=" + 0.8);
            }
            else
            {
                Console.WriteLine("SuccessRate =" + 0.77);
            }
            Console.ReadKey();
            Assemblyline.ProductionRatePerHour();
            Console.WriteLine("Enter RatePerHour:");

            double hr = Convert.ToDouble(Console.ReadLine());
            double res = (hr * 221 * 0.9);
            Console.WriteLine("Production RatePerHour =" + res);
            Console.ReadKey();

            Assemblyline.WorkingItemsPerMinute();
            Console.Write("Enter Minutes:");

            int mint = Convert.ToInt32(Console.ReadLine());

            int result = Convert.ToInt32((6 * 3.6 * 0.9));
            Console.Write(" Working Cars Produced Per MInute =" + result);
            Console.ReadKey();
        }
   }
}
