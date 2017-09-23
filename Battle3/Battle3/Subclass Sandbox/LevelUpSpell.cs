using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle3 {

    // Example of a subclass
    class LevelUpSpell : Spell {
        public override void Activate() {

            playSound("Bahdoop");

            playParticle("Gold Glitter Effect");

            updateGUI("Increase XP");

        }
    }
}
