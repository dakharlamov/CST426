using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle4 {

    // Abstract class to define what a GUI can be
    abstract class GUI {

        public string status = "No view state set yet...";

        // Would normally display UI elements at (x,y)
        public abstract void showGUI(float x, float y);

        // Would normally hide UI elements
        public abstract void hideGUI();

        // Would normally update UI elements 
        public abstract void updateGUI();

        // Would normally set UJI elements
        public abstract void setGUI();


    }
}
