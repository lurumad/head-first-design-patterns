using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class Knight : Character
    {
        public Knight()
        {
            Weapon = new BowAndArrowBehavior();
        }
    }
}
