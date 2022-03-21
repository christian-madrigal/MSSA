using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float age;
            string firstName;
            string address;
            Console.WriteLine("Please enter your Full Name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter age in as a decimal:");
            age = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter you Full Address");
            address = Console.ReadLine();




            Console.WriteLine("Your information:");
            Console.WriteLine("Name is {0} , age is {1} , address is {2}", firstName, age, address);
            Console.ReadLine();




            Console.WriteLine("Int max value :{0}", int.MaxValue);
            Console.WriteLine("Int max value :{0}", int.MinValue);
            Console.WriteLine("Float Max Value : {0}", float.MaxValue);
            Console.WriteLine("Float Min Value : {0}", float.MinValue);
            Console.WriteLine("Decimal Max Value : {0}", decimal.MaxValue);
            Console.WriteLine("Decimal Max Value : {0}", decimal.MinValue);
            Console.WriteLine("Double Max Value : {0}", double.MaxValue);
            Console.WriteLine("Double Min Value : {0}", double.MaxValue);



            Console.ReadLine();





        }
    }
}
