using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle4 {
    class Tests {
        static void Main(string[] args) {

            // Create the provider
            GUIServiceLocator.provide(new MainMenuGUI());

            // Check the satus of the GUI
            Console.WriteLine(GUIServiceLocator.getGUI().status);

            // Call the set function in Main Menu
            GUIServiceLocator.getGUI().setGUI();

            // Check the satus of the GUI
            Console.WriteLine(GUIServiceLocator.getGUI().status);

            // Call the show function in Main Menu
            GUIServiceLocator.getGUI().showGUI(50, 50);

            // Check the satus of the GUI
            Console.WriteLine(GUIServiceLocator.getGUI().status);

            // Call the update function in Main Menu
            GUIServiceLocator.getGUI().updateGUI();

            // Check the satus of the GUI
            Console.WriteLine(GUIServiceLocator.getGUI().status);

            // Call the hide function in Main Menu
            GUIServiceLocator.getGUI().hideGUI();

            // Check the satus of the GUI
            Console.WriteLine(GUIServiceLocator.getGUI().status);

            Console.WriteLine("Press enter to close test...");
            Console.ReadLine();

        }
    }
}
