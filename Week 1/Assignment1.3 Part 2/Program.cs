using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores;
            Console.WriteLine("Please enter the size of array:");
            int size = Int32.Parse(Console.ReadLine());
            scores = new int[size];

            Console.WriteLine($"Please enter {size} scores");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Element {i}: ");
                scores[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"List of Scores in ascending order");
            Array.Sort(scores);
            for (int i = 0; i<size; i++)
            {
                Console.WriteLine(scores[i]);
            }

            Console.WriteLine($"List of scores in descending order:");
            Array.Reverse(scores);
            for (int i = 0; i < size; i++)
            {
                
                Console.WriteLine(scores[i]);
            }

            Console.ReadLine();   
        }        
    }
}
