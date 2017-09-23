using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1 {

    // Spawner class for NPC
    class NPCSpawner {

        private NPC npcVariant; // Prototype to be used when spawning

        public NPCSpawner(NPC prototype) {
            npcVariant = prototype;
        }

        //Spawn by cloning
        public NPC spawnNPC() {

            return npcVariant.clone();

        }

    }
}
