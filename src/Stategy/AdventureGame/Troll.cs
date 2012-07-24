using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class Troll : Character
    {
        public Troll()
        {
            Weapon = new AxeBehavior();
        }
    }
}
