using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class AxeBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "I'm using an Axe";
        }
    }
}
