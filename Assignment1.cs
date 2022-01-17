using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment1
{
    class GetDetails
    {
        public void Details()
        {
            String path = @"C:\capgemini\priya\networklog.txt ";
            FileStream objstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(objstream);
            Console.WriteLine("id\t\tSource\t\t\tDestinattion\t\tDate\t\t\tStatus\t\tNetwork");
            while (sr.Peek() > 0)

            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                {
                    Console.Write(strings[1] + "\t\t");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            GetDetails GetDetailsObj = new GetDetails();
            GetDetailsObj.Details();
            Console.ReadKey();
        }

    }
}

                
                
                   
