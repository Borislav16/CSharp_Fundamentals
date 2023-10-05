using System;

namespace _06._CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int result = RectangleArea(height, width);
            Console.WriteLine(result);
        }
        static int RectangleArea(int height, int width)
        {
            return height * width;
        }
    }
}
