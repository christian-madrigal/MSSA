using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Students Information:");
            Student stu1 = new Student();
            Console.WriteLine("Students ID number");
            stu1.Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the students first name;");
            stu1.studentFname = Console.ReadLine();
            Console.WriteLine("Please enter the students last name");
            stu1.studentLname = Console.ReadLine();
            Console.WriteLine("Please enter the grade for the student");
            stu1.studentGrade = char.Parse (Console.ReadLine());

            Console.WriteLine($"Student Information: {stu1.Id}, {stu1.studentFname}, {stu1.studentLname}, {stu1.studentGrade}");
            

            Console.ReadLine();
        }
    }
}
