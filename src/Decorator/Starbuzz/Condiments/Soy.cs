using Starbuzz.Beverages;

namespace Starbuzz.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .15m + _beverage.Cost();
        }

        public override string ToString()
        {
            return base.ToString() + ", Soy";
        }
    }
}