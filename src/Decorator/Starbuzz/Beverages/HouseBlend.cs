namespace Starbuzz.Beverages
{
    public class HouseBlend : Beverage
    {
        public override decimal Cost()
        {
            return 0.89m;
        }
        public override string ToString()
        {
            return "House Blend Coffe";
        }
    }
}