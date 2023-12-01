using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace _05._EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> emojis = new List<string>();    
            string coolPattern = @"\d";
            string emojiPattern = @"(\:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            ulong coolNumber = 1;

            string input = Console.ReadLine();
            foreach (Match match in Regex.Matches(input, coolPattern))
            {
                coolNumber *= ulong.Parse(match.Value);
            }


            int emojiCount = 0;
            foreach (Match match in Regex.Matches(input, emojiPattern))
            {
                ulong sum = 0;
                string emoji = match.Groups["emoji"].Value;
                emojiCount ++;
                for (int i = 0; i < emoji.Length; i++)
                {
                    sum += emoji[i];
                }
                if(sum >= coolNumber)
                {
                    emojis.Add(match.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolNumber}");
            Console.WriteLine($"{emojiCount} emojis found in the text. The cool ones are:");
            foreach(string emoji in emojis)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
