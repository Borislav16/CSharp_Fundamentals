using System;
using System.Xml.Linq;

namespace _09._GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            Console.WriteLine(Greater(input, num1, num2));
        }
        static string Greater(string inputName, string name1, string name2)
        {
            string result = "";

            switch (inputName)
            {
                case "int":
                    result = (Math.Max(int.Parse(name1), int.Parse(name2))).ToString();
                    break;
                case "char":
                case "string":
                    result = StringResult(name1, name2);
                    break;
                default:
                    break;
            }
            return result;

        }
        static string StringResult(string first, string second)
        {
            int shortLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < shortLength; i++)
            {
                if (first[i] > second[i])
                {   
                    return first;
                }
                else if (second[i] > first[i])
                {
                    return second;
                }
            }

            return first.Length > second.Length ? first : second;
        }
    }
}
