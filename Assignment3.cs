using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        { }
            class Student : Person
        {
            private int[] testScores;
            public Student(String firstName, String lastName, int identification, int[] testScores) : base(firstName, lastName, identification)
            {
                this.testScores = testScores;
            }
            public char Calculate()
            {
                int sum = 0;
                int avg = 0;
                char grade = ' ';
                for (int i = 0; i < testScores.Length; i++)
                {
                    sum += testScores[i];
                }
                if (avg >= 90 && avg <= 100)
                    grade = 'O';
                else
                    if (avg >= 80 && avg < 90)
                    grade = 'E';
                else
                    if (avg >= 70 && avg < 80)
                    grade = 'A';
                else
                if (avg >= 55 && avg < 70)
                    grade = 'p';
                else
                    if (avg >= 40 && avg < 55)
                    grade = 'D';
                else
                    if (avg < 40)
                    grade = 'T';
                return grade;


            }
        } }
    }
class Person
{

}
  

