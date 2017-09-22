using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2 {
    class Tests {
        static void Main(string[] args) {

            List<Entity> entList = new List<Entity>();

            entList.Add(new Ball());
            entList.Add(new Cube());

            Console.WriteLine("Entities added to list. Listing information before Start method call...\n");

            foreach (Entity ent in entList) {
                Console.WriteLine(ent.ToString());
            }

            Console.WriteLine("Calling Start Method. Listing information before Update method call...\n");

            foreach (Entity ent in entList) {
                ent.Start();
                Console.WriteLine(ent.ToString());
            }

            Console.WriteLine("Simulating 20 frames of the game...\n");

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 20; i++) {
                Time.deltaTime = stopWatch.ElapsedMilliseconds / 0.1f;
                stopWatch.Restart();

                foreach (Entity ent in entList) {
                    ent.Update();
                    Console.WriteLine(ent.ToString());
                }


            }

            Console.WriteLine("Press enter to close test...");
            Console.ReadLine();

        }
    }
}
