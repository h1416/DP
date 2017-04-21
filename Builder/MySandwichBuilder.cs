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
            sandwich.BreadType = BreadType.Wheat;
            sandwich.IsToasted = true;
            sandwich.CheeseType = CheeseType.American;
            sandwich.MeatType = MeatType.Turkey;
            sandwich.HasMustard = true;
            sandwich.HasMustard = true;
            sandwich.Vegetables = new List<string> { "Tomato", "Lettuce" };
        }
        
    }
}
