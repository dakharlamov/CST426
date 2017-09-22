using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1
{
    class NPCSpawner
    {
        private NPC npcVariant; // prototype

        public NPCSpawner(NPC prototype){
            npcVariant = prototype;
        }

        public NPC spawnNPC() {

            return npcVariant.clone();

        }

    }
}
