using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "I'm using a Bow & Arrow";
        }
    }
}
