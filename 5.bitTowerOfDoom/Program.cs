using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.bitTowerOfDoom
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] tower = new bool[8, 8];
            byte countKnightsEnteringTheTower = 0;
            for (int i = 0; i < 8; ++i)
            {
                byte chariot = byte.Parse(Console.ReadLine());
                for (int j = 0; j < 8; ++j)
                {
                    if (chariot % 2 == 0 || chariot < 1)
                    {
                        tower[i,j] = false;
                    }
                    else
                    {
                        tower[i, j] = true;
                        countKnightsEnteringTheTower++;
                    }
                    chariot /= 2;
                }
            }

            int deadKnights = 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                byte floor = byte.Parse(Console.ReadLine());
                byte position = byte.Parse(Console.ReadLine());
                if (command == "select")
                {
                    command = "";
                    command = Console.ReadLine();
                    if (command == "kill")
                    {
                        byte defenderFloor = byte.Parse(Console.ReadLine());
                        byte defenderPosition = byte.Parse(Console.ReadLine());
                        if (defenderFloor >= 0 && defenderFloor < 8 ||
                            defenderPosition >= 0 && defenderPosition < 8)
                        {
                            if (tower[defenderFloor, defenderPosition] == true)
                            {
                                tower[floor, position] = false;
                                deadKnights++;
                            }
                            else
                            {
                                if (defenderPosition == 0)
                                {
                                    while (defenderPosition < 8)
                                    {
                                        if (tower[defenderFloor, defenderPosition + 1])
                                        {
                                            tower[defenderFloor, defenderPosition] = false;
                                            tower[floor, position] = false;
                                            deadKnights += 2;
                                            break;
                                        }
                                        defenderPosition++;
                                    }
                                }
                                else if (defenderPosition == 7)
                                {
                                    while (defenderPosition >= 0)
                                    {
                                        if (tower[defenderFloor, defenderPosition - 1])
                                        {
                                            tower[defenderFloor, defenderPosition - 1] = false;
                                            tower[floor, position] = false;
                                            deadKnights += 2;
                                            break;
                                        }
                                        defenderPosition--;
                                    }
                                }
                                else
                                {
                                    if (tower[defenderFloor, defenderPosition - 1] == true &&
                                        tower[defenderFloor, defenderPosition + 1] == true)
                                    {
                                        tower[floor, position] = false;
                                        deadKnights++;
                                    }
                                    else if (tower[defenderFloor, defenderPosition + 1] == true &&
                                               tower[defenderFloor, defenderPosition - 1] == false)
                                    {
                                        tower[defenderFloor, defenderPosition + 1] = false;
                                        tower[floor, position] = false;
                                        deadKnights += 2;
                                    }
                                    else if (tower[defenderFloor, defenderPosition - 1] == true &&
                                               tower[defenderFloor, defenderPosition + 1] == false)
                                    {
                                        tower[defenderFloor, defenderPosition - 1] = false;
                                        tower[floor, position] = false;
                                        deadKnights += 2;
                                    }
                                    else
                                    {
                                        byte startPosition = defenderPosition;
                                        bool isThereDefender = false;
                                        while (isThereDefender == false && defenderPosition < 7)
                                        {
                                            if (tower[defenderFloor, defenderPosition] == true)
                                            {
                                                tower[floor, position] = false;
                                                tower[defenderFloor, defenderPosition] = false;
                                                deadKnights += 2;
                                                isThereDefender = true;
                                            }
                                            defenderPosition++;
                                        }
                                        if (isThereDefender == false)
                                        {
                                            defenderPosition = startPosition;
                                            while (isThereDefender == false && defenderPosition >= 0)
                                            {
                                                if (tower[defenderFloor, defenderPosition] == true)
                                                {
                                                    tower[floor, position] = false;
                                                    tower[defenderFloor, defenderPosition] = false;
                                                    deadKnights += 2;
                                                    isThereDefender = true;
                                                }
                                                defenderPosition--;
                                            }
                                        }
                                        if (isThereDefender == false)
                                        {
                                            tower[floor, position] = false;
                                            tower[defenderFloor, startPosition] = true;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (floor > 2)
                            {
                                deadKnights++;
                                tower[floor, position] = false;
                            }
                            else
                            {
                                tower[floor, position] = false;
                            }
                        }
                    }
                    else if (command == "move")
                    {
                        byte defenderFloor = byte.Parse(Console.ReadLine());
                        byte defenderPosition = byte.Parse(Console.ReadLine());
                        if (defenderFloor >= 0 && defenderFloor < 8 ||
                            defenderPosition >= 0 && defenderPosition < 8)
                        {
                            if (tower[defenderFloor, defenderPosition] == true)
                            {
                                tower[floor, position] = false;
                                deadKnights++;
                            }
                            else
                            {
                                tower[floor, position] = false;
                                tower[defenderFloor, defenderPosition] = true;
                            }
                        }
                        else
                        {
                            if (floor > 2)
                            {
                                deadKnights++;
                                tower[floor, position] = false;
                            }
                            else
                            {
                                tower[floor, position] = false;
                            }
                        }
                    }
                }
                command = "";
                command = Console.ReadLine();
            }

            Console.WriteLine(countKnightsEnteringTheTower);
            Console.WriteLine(countKnightsEnteringTheTower - deadKnights);
            int sum = 0;
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (tower[i, j] == true)
                    {
                        sum += (int)Math.Pow(2, j);
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
