using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07._MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string pattern = @"(?<word>(?<4>\@|\#)([A-Za-z]){3,}\4)(?<mirror>\4[A-Za-z]{3,}\4)";
            int pairs = 0;

            var matches = Regex.Matches(input, pattern);

            List<string> mirrors = new List<string>();

            foreach (Match match in matches)
            {
                string word = match.Groups["word"].Value;
                string mirror = match.Groups["mirror"].Value;

                char a = word[0];
                if (word[0] == mirror[mirror.Length - 1] )
                {
                    pairs++;

                    var mirrored = new string(mirror.Reverse().ToArray());
                    if (word == mirrored)
                    {
                        string matchSymbolsPattern = @"(?:\@|\#)";
                        string cleanWord = Regex.Replace(word, matchSymbolsPattern, "");
                        string cleanMirror = Regex.Replace(mirror, matchSymbolsPattern, "");
                        mirrors.Add($"{cleanWord} <=> {cleanMirror}");
                    }
                }
            }

            if (pairs == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairs} word pairs found!");
            }

            if (mirrors.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrors));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
