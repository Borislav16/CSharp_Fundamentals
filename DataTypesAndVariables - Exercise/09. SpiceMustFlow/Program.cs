using System;

namespace _09._SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int yield = 0;
            int daysCount = 0;
            while (startingYield >= 100) 
            {
                yield += startingYield - 26;
                startingYield -= 10;
                daysCount++;
                
                
            }
            yield -= 26;
            if(yield < 0)
            {
                yield = 0;
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(yield);
        }
    }
}
