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
        public BreadType BreadType { get; set; }

        public bool IsToasted { get; set; }

        public CheeseType CheeseType { get; set; }

        public MeatType MeatType { get; set; }

        public bool HasMustard { get; set; }

        public bool HasMayo { get; set; }

        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine($"Sandwich on {BreadType} bread");
            if (IsToasted)
                Console.WriteLine("Toasted");
            if (HasMayo)
                Console.WriteLine("With Mayo");
            if (HasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine($"Meat: {MeatType}");
            Console.WriteLine($"Cheese: {CheeseType}");
            Console.WriteLine("Veggies: ");
            Vegetables.ForEach(x => Console.WriteLine($"     -{x}"));
        }
    }
}
