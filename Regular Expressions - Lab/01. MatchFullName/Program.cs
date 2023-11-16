using System;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.Write($"{match.Groups[0]} {match.Groups[1]}");
            }
            Console.WriteLine();
        }
    }
}
