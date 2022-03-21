using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while (choice == 'y' || choice == 'Y')
            {
                Callmenu();
                Console.WriteLine("Do you which to continue? Enter Y for Yes and N for No");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }
        static void Callmenu()
        {
            Console.WriteLine("Which operation would you like to perform");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Mulitiplication");
            Console.WriteLine("Enter your choice");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Substraction();
                    break;
                case 3:
                    Multiplication();
                    break;

                default:
                    break;

            }

        }
        static void Addition()
        {
            Console.WriteLine("enter 2 numbers");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("result is " +  result);

        }
        static void Substraction()
        {
            Console.WriteLine("enter 2 numbers");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 - num2;
            Console.WriteLine("result is " + result);
        }
        static void Multiplication()
        {
            Console.WriteLine("enter 2 numbers");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine("result is " + result);


        }
    
    }
}
