using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle5 {

    // Object Pool in the form of a vertex Pool
    class VertexPool {

        private static int poolSize = 100;

        Vertex[] verticies;

        // Initialize all verts with isUse = false
        public VertexPool() {

            verticies = new Vertex[poolSize];

            for (int i = 0; i < poolSize; i++) {

                verticies[i] = new Vertex(i);

            }

        }

        // Try to add vertex to pool, if it fails, it will talk to console
        public void addVertex() {

            int rn = RandomUtility.notBrokenRandomNum();

            for (int i = 0; i < poolSize; i++) {

                if (!verticies[i].inUse) {


                    verticies[i].replace(rn);
                    return;
                }

            }

            Console.WriteLine("VertexPool is full and could not add vertex: " + rn);

        }

        // calls all the vertex's act functions
        public void enact() {

            foreach (Vertex vert in verticies) {

                vert.act();

            }

        }

        // Concatinate all the vertex infos
        public string getInfo() {

            string data = "";

            foreach (Vertex vert in verticies) {

                data += vert.ToString();

            }

            return data;

        }


        //Ease of debuging with ToString overload
        public override string ToString() {

            int numInUse = 0;

            foreach (Vertex vert in verticies) {
                if (vert.inUse)
                    numInUse++;
            }

            return "There are currently " + numInUse + " slots used in the VertexPool.";

        }



    }
}
