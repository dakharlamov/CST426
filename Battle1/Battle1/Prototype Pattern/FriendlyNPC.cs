using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1
{
    class FriendlyNPC : NPC
    {

        public int friendliness;

        public FriendlyNPC() {
            health = 100;
            xp = 50;
            friendliness = 100;
        }

        public override string ToString() {
            return base.ToString() + "Friendliness: " + friendliness + "\n";
        }

        public override NPC clone()
        {
            return new FriendlyNPC();
        }

    }
}
