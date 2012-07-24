using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class King : Character
    {
        public King()
        {
            Weapon = new SwordBehavior();
        }
    }
}
