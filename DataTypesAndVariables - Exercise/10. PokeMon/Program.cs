using System;

namespace _10._PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int originalValue = n;
            int targetsCount = 0;
            while(n >= m)
            {
                n -= m;
                targetsCount++;
                if(n == originalValue / 2)
                {
                    if(y != 0)
                    {
                        n /= y;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetsCount);
        }
    }
}
