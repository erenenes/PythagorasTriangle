
using System;

namespace Pisagor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3-4-5 // 5-12-13 // 8-15-17 // 7-24-25
            int n = 1000;
            int[] trianglesTotal = new int[] { 12, 30, 40, 56 };
            int[,] triangles = new int[,] { { 3, 4, 5 }, { 5, 12, 13 }, { 8, 15, 17 }, { 7, 24, 25 } };
            int multiple = 1;
            int index = 0;
            int[] result = new int[3];

            for (int i = 0; i < trianglesTotal.Length; i++)
            {
                if (n % trianglesTotal[i] == 0)
                {
                    multiple = n / trianglesTotal[i];
                    index = i;
                    break;
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = triangles[index, i] * multiple;
            }
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
            Console.ReadKey();
        }
    }
}
