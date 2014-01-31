namespace Starbuzz.Beverages
{
    public class DarkRoast : Beverage
    {
        public override decimal Cost()
        {
            return 0.99m;
        }

        public override string ToString()
        {
            return "Dark Roast Coffee";
        }
    }
}