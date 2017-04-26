using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorators
{
    public class Pepper : PizzaDecorator
    {
        public Pepper(Pizza pizza)
            : base(pizza)
        {
            Description = "Pepper";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
}
}
