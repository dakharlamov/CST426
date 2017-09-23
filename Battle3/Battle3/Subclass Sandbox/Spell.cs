using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle3 {

    // Template for making other spells
    abstract class Spell {

        // Override this to implement spell functionality
        public abstract void Activate();


        // Operator Methods below

        protected static void playSound(string sound) {
            EngineSimulation.PlaySound(sound);
        }

        protected static void playParticle(string part) {
            EngineSimulation.PlayParticle(part);
        }

        protected static void applyForce(string force) {
            EngineSimulation.ApplyForce(force);
        }

        protected static void updateGUI(string gui) {
            EngineSimulation.UpdateGUI(gui);
        }

    }
}
