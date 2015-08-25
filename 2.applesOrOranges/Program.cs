using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.applesOrOranges
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringN = Console.ReadLine();
            ulong N;
            if (stringN[0] == '-')
            {
                stringN = stringN.Replace('-', '0');
                N = ulong.Parse(stringN);
            }
            else
            {
                N = ulong.Parse(stringN);
            }
            ulong sumEvenNumbers = 0;
            ulong sumOddNumbers = 0;
            while(N != 0)
            {
                ulong currentDigit = N % 10;
                if (currentDigit % 2 == 0)
                {
                    sumEvenNumbers += currentDigit;
                }
                else
                {
                    sumOddNumbers += currentDigit;
                }
                N /= 10;
            }
            if (sumEvenNumbers > sumOddNumbers)
            {
                Console.Write("apples " + sumEvenNumbers);
            }
            else if(sumOddNumbers > sumEvenNumbers)
            {
                Console.Write("oranges " + sumOddNumbers);
            }
            else 
            {
                Console.Write("both " + sumOddNumbers);
            }
            Console.WriteLine(" ");
        }
    }
}
