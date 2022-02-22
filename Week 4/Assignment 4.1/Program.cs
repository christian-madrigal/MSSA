using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1
{
    class Program
    {

        static bool leap(int year)
        {


            if (year / 400 == 0)
                return true;

            if (year / 100 == 0)
                return false;

            if (year / 4 == 0)
                return true;
            return false;
        }

 
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 4.1");
            Console.WriteLine("--------------\n");
            char choice1 = 'y';
            char choice2 = 'n';
            while (choice1 == 'y' || choice1 == 'Y')
            {
                HelpfulFunctions();
                Console.WriteLine("\nDo you wish to continue? Enter Y for yest or N for No");
                choice1 = Convert.ToChar(Console.ReadLine());
            }
            while (choice2 == 'n' || choice2 == 'N')
            {
                Console.WriteLine("Thank you for using the Function on this Console");
                choice2 = Convert.ToChar(Console.ReadLine());
            }

        }
        static void HelpfulFunctions()
        {
            Console.WriteLine("Please choos an operation you would like to try\n");
            Console.WriteLine("1. Return even numbers");
            Console.WriteLine("2. Check if the given year is leap");
            Console.WriteLine("3. Entering string and output will be in reverse");
            Console.WriteLine("4. Counting the number of spaces in a given String");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    evenNum();
                    break;
                case 2:
                    leapyear();
                    break;
                case 3:
                    rev();
                    break;
                case 4:
                    spaces();
                    break;

                default:
                    break;
            }

        }
        static void evenNum()
        {
            int i;
            int num1 = 0;
            for (i = 0; i < 100; i++)
            {
                if ((num1 > 0) && (num1 % 2 == 0))
                {

                    StringBuilder even = new StringBuilder();
                    even.Append(num1.ToString() + ' ');
                    Console.Write(even + "\t");

                }
                num1++;
            }


        }
        static void leapyear()
        {
            int year;
            Console.Write("Please enter a year ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIs " + year + " a leap year? " + (leap(year)));

        }
        static void rev()
        {
            Console.WriteLine("Please enter a phrase to show it be reversed");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("\nThe phrase you have chosen has been reversed and it is: " + new string(charArray));
        }
        static void spaces()
        {
            Console.WriteLine("Please form a sentence");
            string str = Console.ReadLine();
            int spaces = 0;
            for(int i = 0;i<str.Length;i++)
            {
                if(str[i] == ' ')
                {
                    spaces++;
                }
            }
            Console.Write("\nThe space between each word is: " + spaces);

        }
    }
}

