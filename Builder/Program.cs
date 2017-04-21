using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Sandwich();

            sandwich.BreadType = BreadType.Wheat;
            sandwich.IsToasted = true;
            sandwich.CheeseType = CheeseType.American;
            sandwich.MeatType = MeatType.Turkey;
            sandwich.HasMustard = true;
            sandwich.HasMustard = true;
            sandwich.Vegetables = new List<string> { "Tomato", "Lettuce" };

            sandwich.Display();

            Console.ReadKey();
        }
    }
}
