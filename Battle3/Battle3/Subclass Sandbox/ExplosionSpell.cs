using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle3 {

    // Example of a subclass
    class ExplosionSpell : Spell {


        public override void Activate() {

            playSound("Boom");

            playParticle("Explosion Effect");

            applyForce("Point force large");

        }



    }
}
