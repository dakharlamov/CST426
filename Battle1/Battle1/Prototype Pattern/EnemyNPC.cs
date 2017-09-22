using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1
{
    class EnemyNPC : NPC
    {

        public int aggression;

        public EnemyNPC()
        {
            health = 100;
            xp = 75;
            aggression = 100;
        }

        public override string ToString() {
            return base.ToString() + "Aggression: " + aggression + "\n";
        }

        public override NPC clone()
        {
            return new EnemyNPC();
        }

    }
}
