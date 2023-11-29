using System;

namespace _04._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = string.Empty;
            while((command = Console.ReadLine()) != "Generate") 
            {
                string[] splitedCommand = command.Split(">>>");
                if (splitedCommand[0] == "Contains")
                {
                    string substring = splitedCommand[1];
                    if(input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if(splitedCommand[0] == "Flip")
                {
                    int startIndex = int.Parse(splitedCommand[2]);
                    int lastIndex = int.Parse(splitedCommand[3]);
                    
                    if (splitedCommand[1] == "Upper")
                    {
                        string newKey = input.Substring(0, startIndex);
                        string toUpper = input.Substring(startIndex, lastIndex - startIndex);
                        newKey += toUpper.ToUpper();
                        newKey += input.Substring(lastIndex);
                        input = newKey;
                        Console.WriteLine(input);
                    }
                    else
                    {
                        string newKey = input.Substring(0, startIndex);
                        string toUpper = input.Substring(startIndex, lastIndex - startIndex);
                        newKey += toUpper.ToLower();
                        newKey += input.Substring(lastIndex);
                        input = newKey;
                        Console.WriteLine(input);
                    }
                }
                else if (splitedCommand[0] == "Slice")
                {
                    int startIndex = int.Parse(splitedCommand[1]);
                    int lastIndex = int.Parse(splitedCommand[2]);
                    input = input.Remove(startIndex, lastIndex - startIndex);
                    Console.WriteLine(input);
                }
            
            }
            Console.WriteLine($"Your activation key is: {input}");
            
            
        }
    }
}
