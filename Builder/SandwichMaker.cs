namespace Builder
{
    class SandwichMaker
    {
        private SandwichBuilder _sandwichBuilder;

        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void BuildSandwich()
        {
            _sandwichBuilder.CreateSandwich();
            _sandwichBuilder.PrepareBread();
            _sandwichBuilder.ApplyMeatAndCheese();
            _sandwichBuilder.ApplyVeggies();
            _sandwichBuilder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return _sandwichBuilder.GetSandwich();
        }
    }
}
