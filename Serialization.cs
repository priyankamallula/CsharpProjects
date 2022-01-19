using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    public class Demo
    {
        
        
        public string ApplicationName { get; set; }
        public int ApplicationId { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Serialization.SerializeData();
            Serialization.DeSerializeData();

            Console.ReadKey();
        }
    }
    class Serialization
    {
        public static void SerializeData()
        {
            Demo obj = new Demo();
            obj.ApplicationId = 1001;
            obj.ApplicationName = "Binary";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(@"D:\Training\priyanka.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream,obj);
            stream.Close();
        }
        public static void DeSerializeData()
        {
            FileStream fs = new FileStream(@"D:\Training\priyanka.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo objnew = (Demo)formatter.Deserialize(fs);

            Console.WriteLine(objnew.ApplicationId);
            Console.WriteLine(objnew.ApplicationName);

        }
    }
      
}

