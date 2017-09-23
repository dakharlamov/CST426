using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle4 {

    // Example of implemented GUI
    class PauseMenuGUI : GUI {
        public override void hideGUI() {
            Console.WriteLine("Pause Menu Hidden");
        }

        public override void setGUI() {
            Console.WriteLine("Pause Menu Set");
        }

        public override void showGUI(float x, float y) {
            Console.WriteLine("Pause Menu shown at: " + x + ", " + y);
        }

        public override void updateGUI() {
            Console.WriteLine("Pause Menu updated");
        }
    }
}
