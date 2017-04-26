using Decorator.Decorator;
using Decorator.Component;

namespace Decorator.ConcreteDecorators
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza)
            : base(pizza)
        {
            Description = "Ham";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.00;
        }
    }
}
