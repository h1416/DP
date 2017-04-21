using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwichBuilder = new MySandwichBuilder();
            sandwichBuilder.CreateSandwich();
            var sandwich = sandwichBuilder.GetSandwich();
            sandwich.Display();
            Console.ReadKey();
        }
    }
}
