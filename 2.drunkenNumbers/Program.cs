using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.drunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sumBeersVladko = 0;
            int sumBeersVladkoitko = 0;
       
            for (int i = 1; i <= N; ++i)
            {
                int drunkNumber = int.Parse(Console.ReadLine());
                if (drunkNumber < 0)
                {
                    drunkNumber *= (-1);
                }
                int drunkNumberCopy = drunkNumber;
                int drunkNumberLength = 0;
            
                while (drunkNumberCopy != 0)
                {
                    drunkNumberLength++;
                    drunkNumberCopy /= 10;
                }
       
                if (drunkNumberLength % 2 == 0)
                {
                    int beersPlayerRound = 0;
                
                    for (int j = 1; j <= (drunkNumberLength / 2); ++j)
                    {
                        beersPlayerRound += (drunkNumber % 10);
                        drunkNumber /= 10;
                    }

                    sumBeersVladkoitko += beersPlayerRound;
                    beersPlayerRound = 0;

                    for (int j = 1; j <= (drunkNumberLength / 2); ++j)
                    {
                        beersPlayerRound += (drunkNumber % 10);
                        drunkNumber /= 10;
                    }
                    sumBeersVladko += beersPlayerRound;
                }
                else
                {
                    int beersPlayerRound = 0;
                    
                    for (int j = 1; j <= ((drunkNumberLength / 2) + 1); ++j)
                    {
                        beersPlayerRound += (drunkNumber % 10);
                        if (j == ((drunkNumberLength / 2) + 1))
                        {
                            break;
                        }
                        drunkNumber /= 10;
                    }

                    sumBeersVladkoitko += beersPlayerRound;
                    beersPlayerRound = 0;
                    
                    for (int j = 1; j <= ((drunkNumberLength / 2) + 1); ++j)
                    {
                        beersPlayerRound += (drunkNumber % 10);
                        drunkNumber /= 10;
                    }
                    sumBeersVladko += beersPlayerRound;
                }
            }

            if (sumBeersVladko > sumBeersVladkoitko)
            {
                Console.WriteLine("M {0}", sumBeersVladko - sumBeersVladkoitko);
            } 
            else if (sumBeersVladko < sumBeersVladkoitko)
            {
                Console.WriteLine("V {0}", sumBeersVladkoitko - sumBeersVladko);
            }
            else
            {
                Console.WriteLine("No {0}", sumBeersVladkoitko + sumBeersVladko);
            }
        }
    }
}
