using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2 {
    class Ball : Entity {

        private float radius;

        public override void Start() {
            base.Start();
            position = new Float3();
            radius = 5;
        }

        public override void Update() {
            base.Update();
            position = position + Float3.forward * Time.deltaTime;

            radius = Time.deltaTime * 33;
        }

        public override string ToString() {
            return base.ToString() + "Radius: " + radius + "\n";
        }

    }
}
