using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _06._CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                int winningCard = 0;
                int losingCard = 0;
                if (!(firstDeck.Count <= 0 || secondDeck.Count <= 0))
                {
                    if (firstDeck[0] > secondDeck[0])
                    {
                        winningCard = firstDeck[0];
                        losingCard = secondDeck[0];

                        firstDeck.RemoveAt(0);
                        secondDeck.RemoveAt(0);

                        firstDeck.Add(winningCard);
                        firstDeck.Add(losingCard);

                    }
                    else if (firstDeck[0] < secondDeck[0])
                    {
                        winningCard = secondDeck[0];
                        losingCard = firstDeck[0];

                        firstDeck.RemoveAt(0);
                        secondDeck.RemoveAt(0);

                        secondDeck.Add(winningCard);
                        secondDeck.Add(losingCard);
                    }
                    else
                    {
                        firstDeck.RemoveAt(0);
                        secondDeck.RemoveAt(0);
                    }
                }
                else
                {
                    break;
                }

            }
            if (firstDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
