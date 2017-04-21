using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker.BuildSandwich();
            sandwichMaker.GetSandwich().Display();

            Console.WriteLine();

            sandwichMaker = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker.BuildSandwich();
            sandwichMaker.GetSandwich().Display();

            Console.ReadKey();
        }
    }
}
