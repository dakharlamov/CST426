using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle5 {

    // Object that goes into the object pool
    class Vertex {


        public float x, y, z, w;

        public float u, v;

        public bool inUse;


        public Vertex(int idx) {
            x = idx;
            y = idx;
            z = idx;
            w = idx;

            u = idx;
            v = idx;
            inUse = false;
        }

        // Called when isUse is false and the date will be replace by something else
        public void replace(int idx) {
            x = idx;
            y = idx;
            z = idx;
            w = idx;

            u = idx;
            v = idx;

            inUse = true;
        }

        // Usually has some behavior but instead just randomly chooses when to be invalid
        public void act() {

            if (RandomUtility.notBrokenRandomNum() % 5 == 0)
                inUse = false;

        }

        public override string ToString() {

            return "This is vertex " + x + " and I am currently " + (inUse ? "in use.\n" : "not in use.\n");
        }


    }
}
