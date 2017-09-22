﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle3 {
    class EngineSimulation {


        public static void EngineCallPlaySound(string sound) {
            Console.WriteLine("[ENGINE] Playing sound: " + sound);
        }

        public static void PlayParticle(string part) {
            Console.WriteLine("[ENGINE] Playing particle: " + part);
        }

        public static void ApplyForce(string force) {
            Console.WriteLine("[ENGINE] Applying Force: " + force);
        }

        public static void UpdateGUI(string gui) {
            Console.WriteLine("[ENGINE] Updating GUI: " + gui);
        }


    }
}
