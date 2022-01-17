using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        private string rollNo, name, course;
        private double totalFee, dueamount;
        public double TotalFee
        {
            get { return totalFee; }
            set { totalFee = value; }
        }
        public double DueAmount
        {
            get { return dueamount; }
            set { dueamount = value; }

        }
        public void Enroll(String r, String n, String c)
        {
            rollNo = r;
            name = n;
            course = c;
            if (c.Equals("C#"))
            {
                TotalFee = 2000;
                DueAmount = 2000;
            }
            else
            {
                TotalFee = 3000;
                DueAmount = 3000;
            }
        }
        public void Payment(double amount)
        {
            if (dueamount >= amount)
                DueAmount -= amount;
            else
                DueAmount = 0;
        }
        public void print()
        {
            Console.WriteLine("\nRoll Number :" + rollNo);
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Course :" + course);
            Console.WriteLine("Total Fee  :" + TotalFee);
            Console.WriteLine("DueAmount :" + DueAmount);

        }
    }
    class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Enroll("123", "priya", "C#");
            Student s2 = new Student();
            s2.Enroll("126", "Revathi", "Asp.Net");
            s1.Payment(1000);
            s2.Payment(1000);
            s1.print();
            s2.print();
            Console.ReadKey();
        }
    }
}
    

