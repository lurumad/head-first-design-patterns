namespace Starbuzz.Beverages
{
    public class Espresso : Beverage
    {
        public override decimal Cost()
        {
            return 1.99m;
        }

        public override string ToString()
        {
            return "Espresso";
        }
    }
}