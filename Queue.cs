using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueObj
{
    class QueueObjects
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            int total = 3;
            for (int i = 0; i < total; i++ )
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                queue.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }
            Person p = (Person)queue.Dequeue();
            Console.WriteLine(p.ToString());
        }
    }
    class Person
    {
     public   string Name { get; set;  }
        public int Age { get; set; }

        public override string ToString()
        
            
            {
                return Name + "-" + Age;
            }
        


    }
}
