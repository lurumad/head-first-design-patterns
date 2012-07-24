using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class Queen : Character
    {
        public Queen()
        {
            Weapon = new KnifeBehavior();
        }
    }
}
