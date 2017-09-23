using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle3 {

    // Example of a subclass
    class JumpSpell : Spell {

        public override void Activate() {

            playSound("Boinggggg");

            playParticle("Blue Glitter Effect");

            applyForce("Force small up");


        }
    }
}
