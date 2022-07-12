﻿using System;

namespace Combinations_With_Repetitions
{
    internal class Program
    {
        static string[] elements;
        static string[] combinations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            int k = int.Parse(Console.ReadLine());
            combinations = new string[k];


            Combinate(0, 0);

        }

        private static void Combinate(int index, int start)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(String.Join(" ", combinations).TrimEnd());
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {


                combinations[index] = elements[i];
                Combinate(index + 1, i);

            }
        }
    }
}
