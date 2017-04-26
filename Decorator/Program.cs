using Decorator.Component;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Plain large pizza
            Pizza largePizza = new LargePizza();
            Display(largePizza);

            // Add cheese
            largePizza = new Cheese(largePizza);
            Display(largePizza);

            // Add Ham
            largePizza = new Ham(largePizza);
            Display(largePizza);

            // Add pepper
            largePizza = new Pepper(largePizza);
            Display(largePizza);

            Console.ReadKey();
        }

        static void Display(Pizza pizza)
        {
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine("{0:C2}", pizza.CalculateCost());
            Console.WriteLine();
        }
    }
}
