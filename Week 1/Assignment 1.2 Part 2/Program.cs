using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._2_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2;
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
            {
                Console.WriteLine("{0} and {1} are equal.", int1, int2);
            }

            else
            {
                Console.WriteLine("{0} and {1} are not equal.", int1, int2);
            }
            Console.ReadLine();
        }

    }
}
