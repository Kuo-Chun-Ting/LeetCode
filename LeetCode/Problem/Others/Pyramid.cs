using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problem.Others
{
    public class Pyramid
    {
        public void PrintPyramid()
        {
            Console.WriteLine("請輸入");
            var n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                int currLayer = n;
                int max = 2 * n - 1;

                for (int i = 0; i < n; i++)
                {
                    int star = i * 2 + 1; ;

                    for (int j = 1; j <= max; j++)
                    {
                        if (j >= currLayer && star != 0)
                        {
                            Console.Write("*");

                            star--;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    currLayer--;

                    Console.WriteLine();
                }

                Console.WriteLine("請輸入");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
