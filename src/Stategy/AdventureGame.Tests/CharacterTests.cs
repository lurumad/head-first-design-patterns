using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdventureGame.Tests
{
    [TestFixture]
    public class CharacterTests
    {
        [Test]
        public void WhenCharacterIsAKingDefaultWeaponIsASword()
        {
            var king = new King();

            var weapon = king.Fight();

            Assert.AreEqual("I'm using a Sword", weapon);
        }

        [Test]
        public void WhenCharacterIsAQueenDefaultWeaponIsAKnife()
        {
            var queen = new Queen();

            var weapon = queen.Fight();

            Assert.AreEqual("I'm using a Knife", weapon);
        }

        [Test]
        public void WhenCharacterIsAKnightDefaultWeaponIsABowAndArrow()
        {
            var knight = new Knight();

            var weapon = knight.Fight();

            Assert.AreEqual("I'm using a Bow & Arrow", weapon);
        }

        [Test]
        public void WhenCharacterIsATrollDefaultWeaponIsAnAxe()
        {
            var troll = new Troll();

            var weapon = troll.Fight();

            Assert.AreEqual("I'm using an Axe", weapon);
        }
    }
}
