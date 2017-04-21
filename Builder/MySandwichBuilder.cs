using System;
using System.Collections.Generic;

namespace Builder
{
    class MySandwichBuilder
    {
        Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateSandwich()
        {
            sandwich = new Sandwich();
            PrepareBread();
            ApplyMeatAndCheese();
            ApplyVeggies();
            AddCondiments();
        }

        private void AddCondiments()
        {
            sandwich.HasMustard = true;
            sandwich.HasMustard = true;
        }

        private void ApplyVeggies()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Lettuce" };
        }

        private void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Turkey;
            sandwich.BreadType = BreadType.Wheat;
        }

        private void PrepareBread()
        {
            sandwich.BreadType = BreadType.Wheat;
            sandwich.IsToasted = true;
        }
    }
}
