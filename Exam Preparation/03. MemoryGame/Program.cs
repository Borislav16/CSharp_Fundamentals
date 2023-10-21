using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> symbols = Console.ReadLine().Split(' ').ToList();
            int moves = 0;
            string command = default;
            while ((command = Console.ReadLine()) != "end")
            {
                moves++;
                string[] indexes = command.Split(' ').ToArray();

                int firstSym = int.Parse(indexes[0]);
                int secondSym = int.Parse(indexes[1]);

                if (firstSym >= 0 && firstSym < symbols.Count
                    && secondSym >= 0 && secondSym < symbols.Count
                    && firstSym != secondSym)
                {
                    if (secondSym > firstSym)
                    {
                        int temp = secondSym;
                        secondSym = firstSym;
                        firstSym = temp;
                    }



                    if (symbols[firstSym] == symbols[secondSym])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {symbols[firstSym]}!");
                        symbols.RemoveAt(firstSym);
                        symbols.RemoveAt(secondSym);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                    if(symbols.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        return;
                    }
                }
                else
                {
                    int middle = symbols.Count / 2;
                    string newSym = $"-{moves}a";
                    symbols.Insert(middle, newSym);
                    symbols.Insert(middle, newSym);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                
                
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", symbols));


        }
    }
}
