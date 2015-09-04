using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.bittris
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            int[] allElements = new int[4];
            int score = 0;
            bool isGameFieldFull = false;

            while (numberOfCommands > 0)
            {
                int currentElement = int.Parse(Console.ReadLine());
                if (isGameFieldFull == false)
                {
                    int countCommandsForAnElement = 0;
                    int count1InLowBits = 0;
                    for (int i = 0; i < 8; ++i)
                    {
                        int mask = 1 << i;
                        int result = currentElement & mask;
                        result = result >> i;
                        if (result == 1)
                        {
                            count1InLowBits++;
                        }
                    }

                    bool shouldDoNothing = false;                  
                    while (countCommandsForAnElement < 3)
                    {
                        string currentCommand = Console.ReadLine();
                        if (shouldDoNothing == false)
                        {                            
                            int copyCurrentElement = currentElement;
                            switch (currentCommand)
                            {
                                case "L":
                                    {
                                        currentElement = currentElement << 1;
                                        break;
                                    }
                                case "R":
                                    {
                                        currentElement = currentElement >> 1;
                                        break;
                                    }
                                case "D":
                                    {
                                        break;
                                    }
                            }
                            int count1InLowBitsAfterCurrentCommand = 0;
                            for (int i = 0; i < 8; ++i)
                            {
                                int mask = 1 << i;
                                int reslt = currentElement & mask;
                                reslt = reslt >> i;
                                if (reslt == 1)
                                {
                                    count1InLowBitsAfterCurrentCommand++;
                                }
                            }

                            bool didTheElementFindPlace = false;
                            int finalRowForTheCurrentElement = 0;

                            if (count1InLowBits != count1InLowBitsAfterCurrentCommand)
                            {
                                currentElement = copyCurrentElement;
                            }

                            int result = allElements[countCommandsForAnElement] & currentElement;
                            if (result != 0 && (countCommandsForAnElement - 1) >= 0)
                            {
                                currentElement = copyCurrentElement;
                                allElements[countCommandsForAnElement - 1] =
                                        allElements[countCommandsForAnElement - 1] |
                                            currentElement;
                                didTheElementFindPlace = true;
                                finalRowForTheCurrentElement = countCommandsForAnElement - 1;
                            }
                            else if (result == 0 && countCommandsForAnElement == 2)
                            {
                                result = allElements[countCommandsForAnElement + 1] & currentElement;
                                if (result == 0)
                                {
                                    allElements[countCommandsForAnElement + 1] = allElements[countCommandsForAnElement + 1] | currentElement;
                                    didTheElementFindPlace = true;
                                    finalRowForTheCurrentElement = countCommandsForAnElement + 1;
                                }
                                else
                                {
                                    allElements[countCommandsForAnElement] = allElements[countCommandsForAnElement] | currentElement;
                                    didTheElementFindPlace = true;
                                    finalRowForTheCurrentElement = countCommandsForAnElement;
                                }
                            }
                            else if (result != 0 && (countCommandsForAnElement - 1) <= 0)
                            {
                                isGameFieldFull = true;
                                break;
                            }

                            if (didTheElementFindPlace == true)
                            {
                                if (allElements[finalRowForTheCurrentElement] == 255)
                                {
                                    allElements[finalRowForTheCurrentElement] = 0;
                                    for (int i = finalRowForTheCurrentElement; i > 0; --i)
                                    {
                                        allElements[i] = allElements[i - 1];
                                    }
                                    allElements[0] = 0;
                                    score += count1InLowBits * 10;
                                }
                                else
                                {
                                    int mask;
                                    for (int i = 0; i < 32; ++i)
                                    {
                                        mask = 1 << i;
                                        int res = currentElement & mask;
                                        int bit = res >> i;
                                        if (bit == 1)
                                        {
                                            score += 1;
                                        }
                                    }
                                }
                                shouldDoNothing = true;
                            }
                        }
                        countCommandsForAnElement++;
                    }
                    numberOfCommands -= 4;
                }
                else
                {
                    string currentCommand = Console.ReadLine();
                }
            }
            Console.WriteLine(score);
        }
    }
}
