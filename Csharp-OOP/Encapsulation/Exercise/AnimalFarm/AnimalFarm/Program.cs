﻿namespace AnimalFarm
{
    using System;
    using AnimalFarm.Models;
  public  class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Chicken chicken = null;
            try
            {
            chicken = new Chicken(name, age);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine(
                "Chicken {0} (age {1}) can produce {2} eggs per day.",
                chicken.Name,
                chicken.Age,
                chicken.ProductPerDay);

            
        }
    }
}
