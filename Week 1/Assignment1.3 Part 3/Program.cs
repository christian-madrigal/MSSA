using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 234, 10, 354, 400, 153 };
            BubbleSort(numbers);
            Console.WriteLine("Descending List:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            AscendingSort(numbers);
            Console.WriteLine("Ascending list:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void BubbleSort(int[]data)
        {
            int temp = 0;
            for(int i=1;i<=data.Length;i++)
            {
                for(int j=0;j<(data.Length-1);j++)
                {
                    if(data[j+1]>data[j])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        static void AscendingSort(int[]data)
        {
            int temp = 0;
            for(int i=1;i<=data.Length; i++)
            {
                for(int j=0;j<(data.Length-1);j++)
                {
                    if(data[j+1]<data[j])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }

        }

    }
}
