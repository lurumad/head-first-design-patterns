using Starbuzz.Beverages;

namespace Starbuzz.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .10m + _beverage.Cost();
        }

        public override string ToString()
        {
            return base.ToString() + ", Whip";
        }
    }
}