using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.AmericanPie
{
    class Program
    {
        static void Main(string[] args)
        {
            uint A = uint.Parse(Console.ReadLine());
            uint B = uint.Parse(Console.ReadLine());
            uint C = uint.Parse(Console.ReadLine());
            uint D = uint.Parse(Console.ReadLine());

            double sumNominator = (double)A * D + (double)B * C;
            double sumDenominator = (double)B * D;
            if (sumNominator / sumDenominator >= 1)
            {
                Console.WriteLine((uint)(sumNominator / sumDenominator));
            }
            else
            {
                Console.WriteLine("{0:F20}", ((double)sumNominator / (double)sumDenominator));
            }
            Console.WriteLine("{0}/{1}", sumNominator, sumDenominator);
        }
    }
}
