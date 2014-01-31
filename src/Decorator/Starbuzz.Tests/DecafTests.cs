using FluentAssertions;
using NUnit.Framework;
using Starbuzz.Beverages;
using Starbuzz.Condiments;

namespace Starbuzz.Tests
{
    [TestFixture]
    public class DecafTests
    {
        [Test]
        public void ToString_Override_ReturnDecafCoffee()
        {
            var decaf = new Decaf();

            decaf.ToString().Should().Be("Decaf Coffee");
        }

        [Test]
        public void Cost_WithoutCondiments_ReturnOneDollarAndFiveCents()
        {
            var decaf = new Decaf();

            var cost = decaf.Cost();

            cost.Should().Be(1.05m);
        }

        [Test]
        public void Cost_WithMocha_ReturnOneDollarAndTwentyFiveCents()
        {
            var decaf = new Decaf();
            var mocha = new Mocha(decaf);

            var cost = mocha.Cost();

            cost.Should().Be(1.25m);
        }
    }
}