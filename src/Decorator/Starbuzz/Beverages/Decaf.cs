namespace Starbuzz.Beverages
{
    public class Decaf : Beverage
    {
        public override decimal Cost()
        {
            return 1.05m;
        }

        public override string ToString()
        {
            return "Decaf Coffee";
        }
    }
}