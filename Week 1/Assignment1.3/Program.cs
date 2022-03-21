using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while (choice == 'y' || choice == 'Y')
            {
                Callmenu();
                Console.WriteLine("Do you wish to continue? Enter Y for yes or N for No");
                choice = Convert.ToChar(Console.ReadLine());

            }
            Console.ReadLine();
        }
        static void Callmenu()
        {
            Console.WriteLine("Please choose an operation");
            Console.WriteLine("1. Finding the Area of a Triangle");
            Console.WriteLine("2. Finding the Area of a Rectangle");
            Console.WriteLine("3. Finding the Area of a Square");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    triangle();
                    break;
                case 2:
                    Rectangle();
                    break;
                case 3:
                    Square();
                    break;

                default:
                    break;

            }

            
        }
        static void triangle()
        {
            Console.WriteLine("Enter the base and height");
            decimal num1, num2;
            num1 = decimal.Parse(Console.ReadLine());
            num2 = decimal.Parse(Console.ReadLine());
            decimal area = 0.5m * num1 * num2;
            Console.WriteLine($"Result is " + area);
        }
        static void Rectangle()
        {
            Console.WriteLine("Enter the Length and Width");
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int area = num1 * num2;
            Console.WriteLine($"Result is " + area);

        }
        static void Square()
        {
            Console.WriteLine("Enter the Length");
            int num1;
            num1 = int.Parse(Console.ReadLine());
            int area = num1*num1; 
            Console.WriteLine($"Result is " + area);
        }
        
    }

}
