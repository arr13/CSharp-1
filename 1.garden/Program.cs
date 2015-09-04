using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomatoSeeds = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberSeeds = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoSeeds = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotSeeds = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageSeeds = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beanSeeds = int.Parse(Console.ReadLine());

            double cost = (double)tomatoSeeds * 0.5 +
                          (double)cucumberSeeds * 0.4 +
                          (double)potatoSeeds * 0.25 +
                          (double)carrotSeeds * 0.6 +
                          (double)cabbageSeeds * 0.3 +
                          (double)beanSeeds * 0.4;
            Console.WriteLine("{0:F2}",cost);

            double area = 250 - (tomatoArea + cucumberArea +
                            potatoArea + carrotArea + cabbageArea);
            if (area < 0)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (area == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Beans area:" + area);
            }
        }
    }
}
