using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace _08._Final_Exam
{

    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            string input = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] splitedCommand = command.Split().ToArray();
                if (splitedCommand[0] == "Change")
                {
                    char oldChar = char.Parse(splitedCommand[1]);
                    char newChar = char.Parse(splitedCommand[2]);
                    input = input.Replace(oldChar, newChar);
                    Console.WriteLine(input);
                }
                else if (splitedCommand[0] == "Includes")
                {
                    string substring = splitedCommand[1];
                    if(input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (splitedCommand[0] == "End")
                {
                    string substring = splitedCommand[1];
                    if (input.EndsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (splitedCommand[0] == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (splitedCommand[0] == "FindIndex")
                {
                    char givenChar = char.Parse(splitedCommand[1]);
                    int index = input.IndexOf(givenChar);
                    Console.WriteLine($"{index}");
                }
                else if (splitedCommand[0] == "Cut")
                {
                    int startIndex = int.Parse(splitedCommand[1]);
                    int endIndex = int.Parse(splitedCommand[2]);
                    string substring = input.Substring(startIndex, endIndex);
                    Console.WriteLine(substring);
                    input = input.Remove(startIndex, endIndex);
                }

            }

        }
    }
}
//int n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    string command = Console.ReadLine();
//    string pattern = @"\!(?<command>[A-Z]{1}[a-z]{2,})\!:\[(?<string>[A-Za-z]{8,})\]";
//    if (Regex.IsMatch(command, pattern) == false)
//    {
//        Console.WriteLine($"The message is invalid");
//        continue;
//    }
//    StringBuilder stringBuilder = new StringBuilder();
//    foreach (Match match in Regex.Matches(command, pattern))
//    {
//        string commandName = match.Groups["command"].Value;
//        string str = match.Groups["string"].Value;
//        for (int j = 0; j < str.Length; j++)
//        {
//            int num = str[j];
//            stringBuilder.Append(new string($" {num}"));
//        }
//        Console.WriteLine($"{commandName}:{stringBuilder}");
//    }
//}

//class Heroes
//{
//    public Heroes(string name, string spell)
//    {
//        Name = name;
//        Spell = new List<string>();
//    }

//    public string Name { get; set; }
//    public List<string> Spell { get; set; }

//    public override string ToString()
//    {
//        return (string.Join(", ", Spell));
//    }
//}

//List<Heroes> heroes = new List<Heroes>();
//string command = string.Empty;
//while ((command = Console.ReadLine()) != "End")
//{
//    string[] splitedCommand = command.Split();
//    if (splitedCommand[0] == "Enroll")
//    {
//        string heroName = splitedCommand[1];
//        Heroes foundHero = heroes.FirstOrDefault(h => h.Name == heroName);
//        if (foundHero is not null)
//        {
//            Console.WriteLine($"{heroName} is already enrolled.");
//            continue;
//        }
//        Heroes hero = new Heroes(heroName, "");
//        heroes.Add(hero);

//    }
//    else if (splitedCommand[0] == "Learn")
//    {
//        string heroName = splitedCommand[1];
//        Heroes foundHero = heroes.FirstOrDefault(h => h.Name == heroName);
//        if (!(foundHero is not null))
//        {
//            Console.WriteLine($"{heroName} doesn't exist.");
//            continue;
//        }
//        string spell = splitedCommand[2];
//        if(!foundHero.Spell.Contains(spell))
//        {
//            foundHero.Spell.Add(spell);
//            continue;
//        }
//        Console.WriteLine($"{heroName} has already learnt {spell}.");
//    }
//    else if (splitedCommand[0] == "Unlearn")
//    {
//        string heroName = splitedCommand[1];
//        string spell = splitedCommand[2];
//        Heroes foundHero = heroes.FirstOrDefault(h => h.Name == heroName);
//        if (!(foundHero is not null))
//        {
//            Console.WriteLine($"{heroName} doesn't exist.");
//            continue;
//        }
//        if (!foundHero.Spell.Contains(spell))
//        {
//            Console.WriteLine($"{heroName} doesn't know {spell}.");
//            continue;
//        }
//        foundHero.Spell.Remove(spell);
//    }
//}
//Console.WriteLine("Heroes:");
//foreach (Heroes hero in heroes)
//{
//    Console.WriteLine($"== {hero.Name}: {hero.ToString()}");
//}