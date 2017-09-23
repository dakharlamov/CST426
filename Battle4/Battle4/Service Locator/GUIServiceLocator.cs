using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle4 {


    // GUI Service Locator to gain access to GUI functions wherever you are
    class GUIServiceLocator {

        private static GUI gui;

        // Get reference of a specific GUI
        public static GUI getGUI() {
            return gui;
        }

        // Specifies which GUI Service to provide
        public static void provide(GUI guiService) {

            gui = guiService;

        }


    }
}
