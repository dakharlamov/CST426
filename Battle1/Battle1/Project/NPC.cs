using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1 {

    //Prototype class for NPCs
    class NPC {

        protected int health;
        protected int xp;

        public NPC() {
            health = 100;
            xp = 25;
        }


        //Generic Cloner method
        public virtual NPC clone() {

            return this;

        }

        //Ease of debuging with ToString overload
        public override string ToString() {

            return "Type: " + GetType() + "\nHealth: " + health + "\nXP: " + xp + "\n";

        }

        //Getters and Setters below

        public void setHealth(int newHealth) {
            health = newHealth;
        }

        public void setXP(int newXP) {
            xp = newXP;
        }

        public int getHealth() {
            return health;
        }

        public int getXP() {
            return xp;
        }


    }
}
