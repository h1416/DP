using Decorator.ConcreteComponents;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var largePizza = new LargePizza();

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
