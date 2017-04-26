namespace Decorator.Component
{
    public abstract class Pizza
    {
        protected string Description { get; set; }
        public abstract string GetDescription();
        public abstract double CalculateCost();
    }
}
