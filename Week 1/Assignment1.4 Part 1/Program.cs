using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Identifying if two giving x points are to the left, right, or the same axis\n");
            char choice = 'y';

            while (choice == 'y' || choice == 'Y')
            {
                Callmenu();
                Console.WriteLine("Would you like to try different points? (Enter y/Y for Yes and n/N for No\n");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
            while (choice =='n'|| choice =='N')
            {
                Console.WriteLine("Thank you");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }
        static void Callmenu()
        {
            Point p1 = new Point();
            Point p2 = new Point();

            Console.WriteLine("Please enter the two numbers for Point 1 starting with x and then y: ");
            p1.x = Int32.Parse(Console.ReadLine());
            p1.y = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers entered are {p1.x} and {p1.y}\n");

            Console.WriteLine("Please enter the two numbers for Point 2 starting with x and then y: ");
            p2.x = Int32.Parse(Console.ReadLine());
            p2.y = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers entered are {p2.x} and {p2.y}\n");

            if (p1.x < p2.x)
            {
                Console.WriteLine("The value x for Point 1 is to the left of the value x of Point 2\n");
            }
            else if (p1.x > p2.x)
            {
                Console.WriteLine("The value x for Point 1 is to the right of the value x of Point 2\n");
            }
            else if (p1.x == p2.x)
            {
                Console.WriteLine("The value x for Point 1 is on the same axis of the value x of Point 2\n");
            }
        }

            
                       
            
        
    }
}
