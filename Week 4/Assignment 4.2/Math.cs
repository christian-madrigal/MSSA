using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2
{
    class MathCls
    {
        public int[,] ArrayProduct(int[,] array1, int[,] array2)
        {
            int row = array1.GetLength(0);
            int col = array1.GetLength(1);
            int[,] prodarray = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    prodarray[i, j] = array1[i, j] + array2[i, j];
                }
            }

            return prodarray;
        }
        public int Add(int a, int b, out int sum)
        {
            sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return sum; 
        }
        public float Multiply (float a, float b, out float product)
        {
            product = a * b;
            return product; 
        }
        public float Multiply (float a, float b, float c, out float product)
        {
            product = a * b * c;
            return product; 
        }
            

    }
}
