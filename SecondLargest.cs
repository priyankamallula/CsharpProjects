using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3,2,1,5,4 };
            Array.Sort(array);  
            Array.Reverse(array);
            Console.WriteLine("Second Highest Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " "); 
            }
            Console.ReadKey();
        }
    }
}
