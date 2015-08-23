using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.coffeeVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int N3 = int.Parse(Console.ReadLine());
            int N4 = int.Parse(Console.ReadLine());
            int N5 = int.Parse(Console.ReadLine());
            float A = float.Parse(Console.ReadLine());
            float P = float.Parse(Console.ReadLine());
            if (A == P)
            {
                Console.WriteLine("Yes {0:F2}", 
                                    N1 * 0.05 +  
                                    N2 * 0.1 + 
                                    N3 * 0.2 +
                                    N4 * 0.5 +
                                    N5 * 1);
            }
            else if (A < P)
            {
                Console.WriteLine("More {0:F2}", P - A);
            }
            else if (A > P && (A - P) < (N1 * 0.05 + N2 * 0.1 + 
                                    N3 * 0.2 + N4 * 0.5 + N5 * 1))
            {
                Console.WriteLine("Yes {0:F2}",
                                    (N1 * 0.05 +
                                    N2 * 0.1 +
                                    N3 * 0.2 +
                                    N4 * 0.5 +
                                    N5 * 1) - (A - P));
            }
            else
            {
                Console.WriteLine("No {0:F2}",
                                        ((A - P) - (N1 * 0.05 +
                                              N2 * 0.1 +
                                              N3 * 0.2 +
                                              N4 * 0.5 +
                                              N5 * 1)));
            }  
        }
    }
}
