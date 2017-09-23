using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2 {

    // Entity to define the structure for an Update-able object
    class Entity {

        public bool hasStarted = false;
        public int framesUpdated = 0;
        public Float3 position = Float3.zero;

        //Ode to Unity
        public virtual void Start() {
            hasStarted = true;
        }

        // Simulate one frame with Update
        public virtual void Update() {
            framesUpdated++;
        }

        //Ease of debuging with ToString overload
        public override string ToString() {
            return "Type: " + this.GetType() + "\nHas Started: " + hasStarted
                + "\nNumber of Frames Simulated in Update: " + framesUpdated
                + "\nPosition: X: " + position.x + " Y: " + position.y + " Z: " + position.z + "\n";
        }
    }
}
