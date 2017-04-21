using System;
using System.Collections.Generic;

namespace Builder
{
    class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMustard = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyVeggies()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Lettuce" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Turkey;
            sandwich.CheeseType = CheeseType.Cheddar;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;
        }
    }
}
