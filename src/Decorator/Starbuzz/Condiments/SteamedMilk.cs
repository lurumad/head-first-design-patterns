using Starbuzz.Beverages;

namespace Starbuzz.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .10m + _beverage.Cost();
        }

        public override string ToString()
        {
            return base.ToString() + ", Steamed Milk";
        }
    }
}