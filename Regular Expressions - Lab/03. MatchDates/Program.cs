using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})(\/|\.|\-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            MatchCollection matches = Regex.Matches(input,pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
