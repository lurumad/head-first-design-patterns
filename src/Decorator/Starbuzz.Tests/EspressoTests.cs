using FluentAssertions;
using NUnit.Framework;
using Starbuzz.Beverages;
using Starbuzz.Condiments;

namespace Starbuzz.Tests
{
    [TestFixture]
    public class EspressoTests
    {
        [Test]
        public void ToString_Override_ReturnEspresso()
        {
            var espresso = new Espresso();

            espresso.ToString().Should().Be("Espresso");
        }

        [Test]
        public void Cost_WithoutCondiments_ReturnOneDollarAndNinetyNineCents()
        {
            var espresso = new Espresso();

            var cost = espresso.Cost();

            cost.Should().Be(1.99m);
        }

        [Test]
        public void Cost_WithMocha_ReturnTwoDollarAndNineteenCents()
        {
            Beverage espresso = new Espresso();
            espresso = new Mocha(espresso);

            var cost = espresso.Cost();

            cost.Should().Be(2.19m);
        }
    }
}