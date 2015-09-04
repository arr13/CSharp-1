using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.secretsOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number[0] == '-')
            {
                number = number.Replace('-', '0');
            }
            
            ulong specialSum = 0;
            uint i = 1;
            int numberLength = number.Length;
            for (int j = 0; j < numberLength; ++j, ++i)
            {
                uint lastDigitOfNumber = 1;
                switch(number[numberLength - j - 1]){
                    case '0': lastDigitOfNumber = 0; break;
                    case '1': lastDigitOfNumber = 1; break;
                    case '2': lastDigitOfNumber = 2; break;
                    case '3': lastDigitOfNumber = 3; break;
                    case '4': lastDigitOfNumber = 4; break;
                    case '5': lastDigitOfNumber = 5; break;
                    case '6': lastDigitOfNumber = 6; break;
                    case '7': lastDigitOfNumber = 7; break;
                    case '8': lastDigitOfNumber = 8; break;
                    case '9': lastDigitOfNumber = 9; break;
                }
                if (i % 2 != 0)
                {
                    specialSum += (lastDigitOfNumber * (i * i));
                }
                else
                {
                    specialSum += (lastDigitOfNumber * lastDigitOfNumber * i);
                }
            }
            Console.WriteLine(specialSum);
            ulong lengthOfSecretAlphaSequence = specialSum % 10;
            if (lengthOfSecretAlphaSequence == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequnce", number);
            }
            else
            {
                ulong R = specialSum % 26;
                for (ulong j = 1, p = (R + 1); j <= lengthOfSecretAlphaSequence; ++j, ++p)
                {
                    if (p > 26)
                    {
                        Console.Write((char)(p - 26 + 64));
                    }
                    else
                    {
                        Console.Write((char)(p + 64));
                    }
                }
                Console.WriteLine("");
            }

        }
    }
}
