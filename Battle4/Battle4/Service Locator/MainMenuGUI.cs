using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle4 {

    // Example of implemented GUI
    class MainMenuGUI : GUI {

        public override void hideGUI() {
            Console.WriteLine("Hiding Main Menu");
            status = "Main menu currently hidden";
        }

        public override void setGUI() {
            Console.WriteLine("Setting Main Menu");
        }

        public override void showGUI(float x, float y) {
            Console.WriteLine("Showing Main Menu at: " + x + ", " + y);
            status = "Main menu currently showing";
        }

        public override void updateGUI() {
            Console.WriteLine("Updating Main Menu");
        }
    }
}
