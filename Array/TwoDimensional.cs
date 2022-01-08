using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class TwoDimensional
    {
        public void Enter2(ref int [,] arr,ref int n,ref int m)
        {
            for(int i = 0; i < n; i++)
                for(int j = 0; j < m; j++)
                {
                    Console.Write("arr[{0},{1}] = ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void Ouput2(int[,] arr, int n, int m)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(arr[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }
}
