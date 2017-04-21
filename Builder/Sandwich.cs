using System;
using System.Collections.Generic;

namespace Builder
{
    enum MeatType
    {
        Turkey,
        Ham,
        Chicken,
        Salami
    }

    enum CheeseType
    {
        American,
        Swiss,
        Cheddar,
        Provolone
    }

    enum BreadType
    {
        White,
        Wheat
    }

    class Sandwich
    {
        private readonly BreadType breadType;
        private readonly bool isToasted;
        private readonly CheeseType cheeseType;
        private readonly MeatType meatType;
        private readonly bool hasMustard;
        private readonly bool hasMayo;
        private readonly List<string> vegetables;

        public Sandwich(BreadType breadType,
            bool isToasted,
            CheeseType cheeseType,
            MeatType meatType,
            bool hasMustard,
            bool hasMayo,
            List<string> vegetables)
        {
            this.breadType = breadType;
            this.isToasted = isToasted;
            this.cheeseType = cheeseType;
            this.meatType = meatType;
            this.hasMustard = hasMustard;
            this.hasMayo = hasMayo;
            this.vegetables = vegetables;
        }

        public void Display()
        {
            Console.WriteLine($"Sandwich on {breadType} bread");
            if (isToasted)
                Console.WriteLine("Toasted");
            if (hasMayo)
                Console.WriteLine("With Mayo");
            if (hasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine($"Meat: {meatType}");
            Console.WriteLine($"Cheese: {cheeseType}");
            Console.WriteLine("Veggies: ");
            vegetables.ForEach(x => Console.WriteLine($"     -{x}"));
        }
    }
}
