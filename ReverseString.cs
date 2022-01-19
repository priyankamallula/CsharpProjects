using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str , reverse = " ";
            int Length ;
            Console.WriteLine("enter a word");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while(Length>=0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
    }
}
