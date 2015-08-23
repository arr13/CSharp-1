using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.fireInTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = (N / 2); i > 0; i--)
            {
                
                for (int j = 1; j <= (N / 2); j++)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                        continue;
                    }
                    Console.Write(".");
                }

                for (int j = (N / 2); j > 0; j--)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                        if (j == 1)
                        {
                            Console.WriteLine("\n");
                        }
                        continue;
                    }
                    Console.Write(".");
                    if (j == 1)
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
            for (int i = 1; i <= (N / 3); ++i)
            {
                for (int j = 1; j <= (N / 2); ++j)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                        continue;
                    }
                    Console.Write(".");
                }
                
                for (int j = (N / 2); j > 0; --j)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                        if (j == 1)
                        {
                            Console.WriteLine("\n");
                        }
                        continue;
                    }
                    Console.Write(".");
                    if (j == 1)
                    {
                        Console.WriteLine("\n");
                    }
                    continue;
                }             
            }
            
            for (int i = 1; i <= N; ++i)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= (N / 2); ++i)
            {
                
                for (int j = 1; j <= (i - 1); ++j)
                {
                    Console.Write(".");
                }

                for (int j = ((N / 2) - i + 1); j > 0; --j)
                {
                    Console.Write(@"\");
                }

                for (int j = ((N / 2) - i + 1); j > 0; --j)
                {
                    Console.Write("/");
                    if (i == 1 && j == 1)
                    {
                        Console.WriteLine("\n");
                    }
                }

                for (int j = 1; j <= (i - 1); ++j)
                {
                    Console.Write(".");
                    if (j == (i - 1))
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }
}
