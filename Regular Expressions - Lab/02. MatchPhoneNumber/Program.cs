using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string input = Console.ReadLine();
            string pattern = @"((\+359 2) (\d{3}) (\d{4})\b)|((\+359-2)-(\d{3})-(\d{4})\b)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                list.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
