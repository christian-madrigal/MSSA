using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 4.2");
            Console.WriteLine("--------------\n");
            char choice1 = 'y';
            char choice2 = 'n';
            while (choice1 == 'y' || choice1 == 'Y')
            {
                Functions();
                Console.WriteLine("\nDo you wish to continue? Enter Y for yest or N for No");
                choice1 = Convert.ToChar(Console.ReadLine());
            }
            while (choice2 == 'n' || choice2 == 'N')
            {
                Console.WriteLine("Thank you for using the Function on this Console");
                choice2 = Convert.ToChar(Console.ReadLine());
            }
        }
        static void Functions()
        {
            Console.WriteLine("Please choos an operation you would like to try\n");
            Console.WriteLine("1. Creating a 2D Array");
            Console.WriteLine("2. Adding two Matrices of the Same Size");
            Console.WriteLine("3. Adding by overloaded methods using two numbers");
            Console.WriteLine("4. Adding by overloaded methods using three numbers");
            Console.WriteLine("5. Multiplying by overloaded methods using two numbers");
            Console.WriteLine("6. Muliplying by overloaded method using three numbers");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    choice1();
                    break;
                case 2:
                    choice2();
                    break;
                case 3:
                    choice3();
                    break;
                case 4:
                    choice4();
                    break;
                case 5:
                    choice5();
                    break;
                case 6:
                    choice6();
                    break;

                default:
                    break;
            }

        }
        static void choice1()
        {

            int rows, cols;
            Console.WriteLine("Please enter the number of rows");
            rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of colums");
            cols = Int32.Parse(Console.ReadLine());
            int[,] array2d = new int[rows, cols];
            Console.WriteLine("Enter the elements in array:");
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Your 2D array looks like this:");
            Console.WriteLine("------------------------");
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write("|{0}|" + "\t", array2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
            
        }
        static void choice2()
        {
            
            MathCls obj = new MathCls();
            Console.WriteLine("Array Operations:");
            int[,] array1 = new int[2,2];
            int[,] array2 = new int[2,2];
            Console.WriteLine("\nEnter array1 elements:");
            for(int i=0;i<array1.GetLength(0); i++)
            {
                for (int j=0;j<array1.GetLength(0);j++)
                {
                    Console.Write($"Element | {i}|{j}|");
                    array1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nEnter array2 elements:");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(0); j++)
                {
                    Console.Write($"Element | {i}|{j}|");
                    array2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nYour first array is:");
            Console.WriteLine("-------------");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write($"|{array1[i, j]}| \t");

                }
                Console.WriteLine();
            
            }
            Console.WriteLine("-------------\n");
            Console.WriteLine("Your second array is:");
            Console.WriteLine("-------------");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write($"|{array2[i, j]}| \t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");
            int[,] prodarray = obj.ArrayProduct(array1, array2);
            Console.WriteLine("\nBoth Array added Together equal:");
            Console.WriteLine("-------------");
            for (int i = 0; i < prodarray.GetLength(0); i++)
            {
                for (int j = 0; j < prodarray.GetLength(1); j++)
                {

                    Console.Write($"|{prodarray[i, j]}|\t");


                }
                Console.WriteLine();

            }
            Console.WriteLine("-------------");


        }
        static void choice3()
        {

            int sum;
            Console.WriteLine("Please enter two numbers");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            MathCls obj = new MathCls();
            obj.Add(a, b, out sum);
            Console.WriteLine($"The Sum of {a} and {b} is {sum}");
            


        }
        static void choice4()
        {
            int sum;
            Console.WriteLine("Please enter three numbers");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            MathCls obj = new MathCls();
            obj.Add(a, b, c, out sum);
            Console.WriteLine($"The Sum of {a} and {b} is {sum}");
        }
        static void choice5()
        {
            float product;
            Console.WriteLine("Please enter two numbers");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            MathCls obj = new MathCls();
            obj.Multiply(a, b, out product);
            Console.WriteLine($"The product of {a} and {b} is {product}");
        }
        static void choice6()
        {
            float product;
            Console.WriteLine("Please enter three numbers");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            MathCls obj = new MathCls();
            obj.Multiply(a, b, c, out product);
            Console.WriteLine($"The product of {a} and {b} and {c} is {product}");
        }
    }
}
