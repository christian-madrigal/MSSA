using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_1._2_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of the first 10 natural numbers");
            int sum = 0;

            for (int i = 1; i <11; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;

            }
            Console.WriteLine($"result is {sum}");
            Console.ReadLine();


        }
    }
}
