using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1
{
    //Prototype
    class NPC
    {
        protected int health;
        protected int xp;

        public NPC() {
            health = 100;
            xp = 25;
        }

        public virtual NPC clone() {

            return this;

        }

        public override string ToString() {
            
            return "Type: " + this.GetType() + "\nHealth: " + this.health + "\nXP: " + this.xp + "\n";

        }

        public void setHealth(int newHealth) {
            this.health = newHealth;
        }

        public void setXP(int newXP) {
            this.xp = newXP;
        }

        public int getHealth() {
            return health;
        }

        public int getXP(){
            return xp;
        }


    }
}
