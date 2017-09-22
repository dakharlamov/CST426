using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2 {
    class Cube : Entity {

        private float scale;

        public override void Start() {
            base.Start();
            position = new Float3(-10, 0 ,0);
            scale = 5;
        }

        public override void Update() {
            base.Update();
            position = position + Float3.right * Time.deltaTime;

            scale = Time.deltaTime * 25;
        }

        public override string ToString() {
            return base.ToString() + "Scale: " + scale + "\n";
        }
    }
}
