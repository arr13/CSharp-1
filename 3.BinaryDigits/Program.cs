using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BinaryDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int decimalN = int.Parse(N);
            string binaryN = "";
            for (int i = 0; i < 16; ++i)
            {
                if (decimalN >= 1){
                    binaryN += Convert.ToString(decimalN % 2);
                }
                else
                {
                    binaryN += "0";
                }
                decimalN /= 2;
            }

            for (int i = 15; i >= 0; --i)
            {
                if (i == 0)
                {
                    if (binaryN[i] == '0')
                    {
                        Console.Write("###\n");
                    }
                    else
                    {
                        Console.Write(".#.\n");
                    }
                    break;
                }
                if (binaryN[i] == '0')
                {
                    Console.Write("###.");
                }
                else
                {
                    Console.Write(".#..");
                }
            }

            for (int i = 15; i >= 0; --i)
            {
                if (i == 0)
                {
                    if (binaryN[i] == '0')
                    {
                        Console.Write("#.#\n");
                    }
                    else
                    {
                        Console.Write("##.\n");
                    }
                    break;
                }
                if (binaryN[i] == '0')
                {
                    Console.Write("#.#.");
                }
                else
                {
                    Console.Write("##..");
                }
            }
            
            for (int i = 15; i >= 0; --i)
            {
                if (i == 0)
                {
                    if (binaryN[i] == '0')
                    {
                        Console.Write("#.#\n");
                    }
                    else
                    {
                        Console.Write(".#.\n");
                    }
                    break;
                }
                if (binaryN[i] == '0')
                {
                    Console.Write("#.#.");
                }
                else
                {
                    Console.Write(".#..");
                }
            }

            for (int i = 15; i >= 0; --i)
            {
                if (i == 0)
                {
                    Console.Write("###\n");
                    break;
                }
                Console.Write("###.");
            }
        }
    }
}
