using System;
using System.Collections.Generic;

namespace Builder
{
    class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMustard = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyVeggies()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Lettuce", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Ham;
            sandwich.CheeseType = CheeseType.American;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.Wheat;
            sandwich.IsToasted = true;
        }
    }
}
