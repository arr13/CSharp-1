using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.neuronMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string stringLine = Console.ReadLine();
                if (stringLine != "-1")
                {
                    uint line = uint.Parse(stringLine);
                    if (line == 0)
                    {
                        Console.WriteLine("0");
                        continue;
                    }
                    else
                    {
                        string stringLineBinary = Convert.ToString(line, 2);
                        byte count10 = 0;
                        int stringLineBinaryLength = stringLineBinary.Length;
                        string newStringLineBinary = "0";
                        int p = 0;
                        for (int i = 0; i < (stringLineBinaryLength - 1); ++i)
                        {
                            if (stringLineBinary[i] == '1' &&
                                stringLineBinary[i + 1] == '0')
                            {
                                count10++;
                            }
                        }
                        if (stringLineBinary[stringLineBinaryLength - 1] == '1' &&
                            stringLineBinary[stringLineBinaryLength - 2] == '0')
                        {
                            count10++;
                        }

                        if (count10 == 1)
                        {
                            Console.WriteLine("0");
                            continue;
                        }

                        while (count10 > 1)
                        {
                            while (stringLineBinary[p] == '1' && stringLineBinary[p + 1] == '1')
                            {
                                newStringLineBinary += "0";
                                p++;
                            }

                            if (stringLineBinary[p] == '1' && stringLineBinary[p + 1] == '0')
                            {
                                int j = p + 1;
                                while (stringLineBinary[j] == '0')
                                {
                                    newStringLineBinary += "1";
                                    j++;
                                }
                                p = j;
                            }

                            while (p < stringLineBinaryLength && stringLineBinary[p] == '1')
                            {
                                newStringLineBinary += "0";
                                p++;
                            }
                            count10--;
                        }
                        for (int i = p; i < stringLineBinaryLength; ++i)
                        {
                            newStringLineBinary += "0";
                        }
                        int lineDecimal = Convert.ToInt32(newStringLineBinary, 2);
                        Console.WriteLine(lineDecimal);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
