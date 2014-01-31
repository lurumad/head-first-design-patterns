using Starbuzz.Beverages;

namespace Starbuzz.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .20m + _beverage.Cost();
        }

        public override string ToString()
        {
            return base.ToString() + ", Mocha";
        }
    }
}