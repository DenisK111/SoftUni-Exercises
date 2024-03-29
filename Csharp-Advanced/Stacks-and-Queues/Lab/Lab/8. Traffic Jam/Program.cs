﻿using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{

    /* Create a program that simulates the queue that forms during a traffic jam. During a traffic jam, only N cars can pass the crossroads when the light goes green. Then the program reads the vehicles that arrive one by one and adds them to the queue. When the light goes green N number of cars pass the crossroads and for each, a message "{car} passed!" is displayed. When the "end" command is given, terminate the program and display a message with the total number of cars that passed the crossroads.
Input
•	On the first line, you will receive N – the number of cars that can pass during a green light
•	On the next lines, until the "end" command is given, you will receive commands – a single string, either a car or "green"
Output
•	Every time the "green" command is given, print out a message for every car that passes the crossroads in the format "{car} passed!"
•	When the "end" command is given, print out a message in the format "{number of cars} cars passed the crossroads."
*/
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> trafficJam = new Queue<string>();
            int passedCars = 0;
            while (true)
            {

                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    int length = Math.Min(n, trafficJam.Count);
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine($"{trafficJam.Dequeue()} passed!");
                        passedCars++;
                    }
                }

                else
                {
                    trafficJam.Enqueue(input);
                }

            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
