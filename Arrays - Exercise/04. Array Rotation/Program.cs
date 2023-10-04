using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        // 60/100 in judge
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numRotations = int.Parse(Console.ReadLine());
            int counterOne = numRotations - 1;
            int counterTwo = numArray.Length - 1;
            int[] switchedArray = new int[numArray.Length];



            for (int i = numArray.Length - 1; i >= 0; i--)
            {

                if (counterOne >= 0)
                {

                    switchedArray[i] = numArray[counterOne];
                    counterOne--;
                }
                else
                {
                    switchedArray[i] = numArray[counterTwo];
                    counterTwo--;
                }

            }

            Console.WriteLine(String.Join(" ", switchedArray));

        }
    }
}
