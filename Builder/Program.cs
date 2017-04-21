using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Sandwich(BreadType.Wheat, false, CheeseType.American, MeatType.Turkey, false, false, new List<string> { "Tomato" });
            sandwich.Display();

            Console.ReadKey();
        }
    }
}
