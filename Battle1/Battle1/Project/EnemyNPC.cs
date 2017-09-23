using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1 {
    class EnemyNPC : NPC {

        public int aggression;

        public EnemyNPC() {
            health = 100;
            xp = 75;
            aggression = 100;
        }

        //Ease of debuging with ToString overload
        public override string ToString() {
            return base.ToString() + "Aggression: " + aggression + "\n";
        }

        // Enemy NPC cloner method
        public override NPC clone() {
            return new EnemyNPC();
        }

    }
}
