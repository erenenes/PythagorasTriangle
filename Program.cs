
using System;

namespace Pisagor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N = 1000;
            int c = 0;
            bool found = false;
            for (int a = 1; a < N/3; a++)
            {
                for (int b = 1; b < N/2; b++)
                {
                    c = N - a - b;
                    if ((a*a)+(b*b)==(c*c))
                    {
                        Console.WriteLine("sonuc : a:"+a+" b:" +b+" c:"+c);
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
            Console.ReadKey();
            
            
            
            // 3-4-5 // 5-12-13 // 8-15-17 // 7-24-25
            //int n = 1000;
            //int[] trianglesTotal = new int[] { 12, 30, 40, 56 };
            //int[,] triangles = new int[,] { { 3, 4, 5 }, { 5, 12, 13 }, { 8, 15, 17 }, { 7, 24, 25 } };
            //int multiple = 1;
            //int index = 0;
            //int[] result = new int[3];

            //for (int i = 0; i < trianglesTotal.Length; i++)
            //{
            //    if (n % trianglesTotal[i] == 0)
            //    {
            //        multiple = n / trianglesTotal[i];
            //        index = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i < result.Length; i++)
            //{
            //    result[i] = triangles[index, i] * multiple;
            //}
            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);
            //Console.WriteLine(result[2]);
            //Console.ReadKey();
            
            //int n = 644;
            //bool isDone = false;
            //for (int x = 1; x < n; x++)
            //{
            //    for (int y = 1; y < n; y++)
            //    {
            //        //if (y <= x)
            //        //    continue;
            //        for (int z = n - (x + y); z < n && z > 0; z--)
            //        {
            //            //if (z <= y && z <= x)
            //            //    continue;

            //            if ((Math.Pow(z, 2) == Math.Pow(x, 2) + Math.Pow(y, 2)) && (x < y))
            //            {
            //                if (x + y + z == n)
            //                {
            //                    Console.WriteLine(" sonuc x:" + x);
            //                    Console.WriteLine(" sonuc y:" + y);
            //                    Console.WriteLine(" sonuc z:" + z);
            //                    isDone = true;
            //                   // break;
            //                }
            //                //listBox1.Items.Add(x.ToString() + "-" + y.ToString() + "-" + z.ToString());
            //                Console.WriteLine(x + " - " + y + " - " + z);
            //            }
            //        }
            //        //if (isDone) break;
            //    }
            //    //if (isDone) break;
            //}
            //Console.ReadKey();
        }
    }
}
