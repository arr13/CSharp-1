using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BatGoikoTower
{
    class Program
    {
        static void Main(string[] args)
        {
            byte H = byte.Parse(Console.ReadLine());
            int p = 1;
            int counter = 1;
            for (int i = 0; i < H; ++i)
            {
                for (int j = (H - i - 2); j >= 0; --j)
                {
                    Console.Write(".");
                }
                Console.Write("/");
                if (i == p)
                {
                    for (int k = 0; k < (2 * H - (2 * (H - i - 1)) - 2); ++k)
                    {
                        Console.Write("-");                        
                    }
                    counter++;
                    p += counter;
                }
                else if (i == 0)
                {
                }
                else
                {
                    for (int l = 0; l < (2 * H - (2 * (H - i - 1)) - 2); ++l)
                    {
                        Console.Write(".");
                    }
                }
                Console.Write("\\");
                for (int j = (H - i - 2); j >= 0; --j)
                {
                    Console.Write(".");
                }
                Console.WriteLine("");
            }
        }
    }
}
