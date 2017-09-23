using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1 {
    class FriendlyNPC : NPC {

        public int friendliness;

        public FriendlyNPC() {
            health = 100;
            xp = 50;
            friendliness = 100;
        }

        //Ease of debuging with ToString overload
        public override string ToString() {
            return base.ToString() + "Friendliness: " + friendliness + "\n";
        }

        // Friendly NPC cloner method
        public override NPC clone() {
            return new FriendlyNPC();
        }

    }
}
