using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1 {
    class Tests {

        static void Main(string[] args) {


            Console.WriteLine("Initializing Generic NPC...");

            NPC genericNPC = new NPC();

            if (genericNPC is NPC) {
                Console.WriteLine("genericNPC initialized as type NPC successfully");
            } else {
                Console.WriteLine("genericNPC failed to initialize as type NPC");
            }


            Console.WriteLine("Initializing Friendly NPC...");
            FriendlyNPC friendlyNPC = new FriendlyNPC();

            if (friendlyNPC is FriendlyNPC && friendlyNPC is NPC) {
                Console.WriteLine("friendlyNPC initialized as type FriendlyNPC and NPC successfully");
            } else {
                Console.WriteLine("friendlyNPC failed to initialize as type NPC and FriendlyNPC");
            }

            Console.WriteLine("Initializing Enemy NPC...");
            EnemyNPC enemyNPC = new EnemyNPC();

            if (enemyNPC is EnemyNPC && enemyNPC is NPC) {
                Console.WriteLine("enemyNPC initialized as type EnemyNPC and NPC successfully");
            } else {
                Console.WriteLine("enemyNPC failed to initialize as type NPC and EnemyNPC");
            }


            Console.WriteLine("Generating List of NPCs to be populated by two spawners: friendly and enemy...");

            List<NPC> npcList = new List<NPC>();

            NPCSpawner friendlySpawner = new NPCSpawner(friendlyNPC);
            NPCSpawner enemySpawner = new NPCSpawner(enemyNPC);

            for (int i = 0; i < 10; i++) {
                if (i > 4)
                    npcList.Add(enemySpawner.spawnNPC());
                else
                    npcList.Add(friendlySpawner.spawnNPC());
            }

            Console.WriteLine("Spawned 5 friendly and 5 enemy NPCs in that order...");

            Console.WriteLine("Checking types of all list items in NPC list...");

            foreach (NPC npc in npcList) {

                Console.WriteLine(npc.GetType());

            }

            Console.WriteLine("Displaying info of NPCs...\n");

            foreach (NPC npc in npcList) {
                Console.WriteLine(npc.ToString());
            }


            Console.WriteLine("Press Enter to close results...");
            Console.ReadLine(); // Wait


        }


    }


}
