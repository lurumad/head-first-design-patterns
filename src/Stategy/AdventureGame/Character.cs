using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public abstract class Character
    {
        public IWeaponBehavior Weapon { get; protected set; }
    
        public string Fight()
        {
            return Weapon.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior weapon)
        {
            Weapon = weapon;
        }
    }
}
