using FluentAssertions;
using NUnit.Framework;
using Starbuzz.Beverages;
using Starbuzz.Condiments;

namespace Starbuzz.Tests
{
    [TestFixture]
    public class DarkRoastTests
    {
        [Test]
        public void ToString_Override_ReturnDarkRoastCoffee()
        {
            var darkRoastCoffee = new DarkRoast();

            darkRoastCoffee.ToString().Should().Be("Dark Roast Coffee");
        }

        [Test]
        public void Cost_WithoutCondiments_ReturnNinetyNineCents()
        {
            var darkRoastCoffee = new DarkRoast();

            var cost = darkRoastCoffee.Cost();

            cost.Should().Be(0.99m);
        }

        [Test]
        public void Cost_WithMocha_ReturnOneDollarAndNineteenCents()
        {
            var darkRoastCoffee = new DarkRoast();
            var mocha = new Mocha(darkRoastCoffee);

            var cost = mocha.Cost();

            cost.Should().Be(1.19m);
        }
    }
}
