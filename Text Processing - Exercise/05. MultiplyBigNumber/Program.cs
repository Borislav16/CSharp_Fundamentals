using System;
using System.Text;

namespace _05._MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            string multiplyNum = Console.ReadLine();
            Console.WriteLine(MultiplyNumbers(bigNum, multiplyNum));
        }

        private static string MultiplyNumbers(string bigNum, string multiplyNum)
        {
            if (bigNum == "0" || multiplyNum == "0")
            {
                return "0";

            }

            int carry = 0;
            int multiplier = int.Parse(multiplyNum);

            char[] resultChars = new char[bigNum.Length + 1];

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNum[i].ToString());
                int product = digit * multiplier + carry;

                resultChars[i + 1] = (char)(product % 10 + '0');
                carry = product / 10;
            }
            if(carry > 0)
            {
                resultChars[0] = (char)(carry + '0');
            }
            return new string(resultChars).TrimStart('\0');

        }
    }
}
