﻿using System;
using System.Linq;

namespace _07._EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            bool isTrue = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i]  != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index ");
                    isTrue = false;
                    break;
                }
                else
                {
                    sum += array1[i];
                }
            }
            if(isTrue == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
