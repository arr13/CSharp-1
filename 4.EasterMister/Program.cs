using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.EasterMister
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int height = 2 * N;
            int width = 3 * N;
            for (int j = (N + 1); j > 0; j -= 2)
            {
                for (int i = 0; i < (3 * N + 1); ++i)
                {
                    if (j == (N + 1) && i > N && i < (2 * N))
                    {
                        Console.Write("*");
                        continue;
                    }
                    if (i == j || i == ((3 * N) - j)){
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(".");
                }
                Console.Write("\n");
            }

            for (int p = 0; p < 2; ++p)
            {
                Console.Write(".*");
                if (p % 2 == 0)
                {
                    for (int j = 0; j < ((3 * N + 1) - 4); ++j)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(".");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < ((3 * N + 1) - 4); ++j)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.Write("*.\n");
            }

            for (int j = 1; j <= (N + 1); j += 2)
            {
                for (int i = 0; i < (3 * N + 1); ++i)
                {
                    if (j == (N + 1) && i > N && i < (2 * N))
                    {
                        Console.Write("*");
                        continue;
                    }
                    if (i == j || i == ((3 * N) - j))
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(".");
                }
                Console.Write("\n");
            }
        }
    }
}

//for (int i = j; i < 0; --i)
//{
//    Console.Write(".");
//}
//if (j == (N + 1))
//{
//    for (int i = 0; i < (N - 1); ++i)
//    {
//        Console.Write("*");
//    }
//    continue;
//}
//Console.Write("*");