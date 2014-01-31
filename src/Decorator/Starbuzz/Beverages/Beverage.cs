using Starbuzz.Annotations;

namespace Starbuzz.Beverages
{
    public abstract class Beverage
    {
        public abstract decimal Cost();

        public override string ToString()
        {
            return "Unknown beverage";
        }
    }
}
