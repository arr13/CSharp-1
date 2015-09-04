using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.cardWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGames = int.Parse(Console.ReadLine());
            bool someoneHasX = false;
            bool has1GotX = false;
            double sumFirstPlayer = 0;
            int wonGamesFirstPlayer = 0;
            bool has2GotX = false;
            int wonGamesSecondPlayer = 0;
            double sumSecondPlayer = 0;

            while (numberOfGames > 0)
            {
                byte countCards = 3;
                double currentSumFirstPlayer = 0;

                while (countCards > 0)
                {
                    string currentCard = Console.ReadLine();
                    switch (currentCard)
                    {
                        case "2": currentSumFirstPlayer += 10; break;
                        case "3": currentSumFirstPlayer += 9; break; 
                        case "4": currentSumFirstPlayer += 8; break;
                        case "5": currentSumFirstPlayer += 7; break;
                        case "6": currentSumFirstPlayer += 6; break;
                        case "7": currentSumFirstPlayer += 5; break;
                        case "8": currentSumFirstPlayer += 4; break;
                        case "9": currentSumFirstPlayer += 3; break;
                        case "10":currentSumFirstPlayer += 2; break;
                        case "A": currentSumFirstPlayer += 1; break;
                        case "J": currentSumFirstPlayer += 11; break;
                        case "Q": currentSumFirstPlayer += 12; break;
                        case "K": currentSumFirstPlayer += 13; break;
                        case "Z": sumFirstPlayer = sumFirstPlayer * 2; break;
                        case "Y": sumFirstPlayer = sumFirstPlayer - 200; break;
                        case "X": has1GotX = true; break;
                    }
                    countCards--;
                }

                countCards = 3;
                double currentSumSecondPlayer = 0;
                
                while (countCards > 0)
                {
                    string currentCard = Console.ReadLine();
                    switch (currentCard)
                    {
                        case "2": currentSumSecondPlayer += 10; break;
                        case "3": currentSumSecondPlayer += 9; break;
                        case "4": currentSumSecondPlayer += 8; break;
                        case "5": currentSumSecondPlayer += 7; break;
                        case "6": currentSumSecondPlayer += 6; break;
                        case "7": currentSumSecondPlayer += 5; break;
                        case "8": currentSumSecondPlayer += 4; break;
                        case "9": currentSumSecondPlayer += 3; break;
                        case "10":currentSumSecondPlayer += 2; break;
                        case "A": currentSumSecondPlayer += 1; break;
                        case "J": currentSumSecondPlayer += 11; break;
                        case "Q": currentSumSecondPlayer += 12; break;
                        case "K": currentSumSecondPlayer += 13; break;
                        case "Z": sumSecondPlayer = sumSecondPlayer * 2; break;
                        case "Y": sumSecondPlayer = sumSecondPlayer - 200; break;
                        case "X": has2GotX = true; break;
                    }
                    countCards--;
                }

                if (has1GotX == true && has2GotX == true)
                {
                    sumFirstPlayer += 50;
                    sumSecondPlayer += 50;
                }
                else if (has1GotX == true || has2GotX == true)
                {
                    someoneHasX = true;
                    break;
                }

                if (currentSumFirstPlayer > currentSumSecondPlayer)
                {
                    sumFirstPlayer += currentSumFirstPlayer;
                    wonGamesFirstPlayer++;
                }
                else if (currentSumSecondPlayer > currentSumFirstPlayer)
                {
                    sumSecondPlayer += currentSumSecondPlayer;
                    wonGamesSecondPlayer++;
                }

                has1GotX = false;
                has2GotX = false;
                numberOfGames--;
            }

            if (someoneHasX == true && has1GotX == true)
            {
                Console.WriteLine("X card drawn!");
                Console.WriteLine("Player one wins the match!");
            }
            else if (someoneHasX == true && has2GotX == true)
            {
                Console.WriteLine("X card drawn!");
                Console.WriteLine("Player two wins the match!");
            }
            else
            {
                if (sumFirstPlayer > sumSecondPlayer)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}", sumFirstPlayer);
                    Console.WriteLine("Games won: {0}", wonGamesFirstPlayer);
                }
                else if (sumFirstPlayer < sumSecondPlayer)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", sumSecondPlayer);
                    Console.WriteLine("Games won: {0}", wonGamesSecondPlayer);
                }
                else if (sumFirstPlayer == sumSecondPlayer)
                {
                    Console.WriteLine("It`s a tie!");
                    Console.WriteLine("Score: {0}", sumFirstPlayer);
                }
            }
        }
    }
}
