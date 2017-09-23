using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle3 {
    class Tests {
        static void Main(string[] args) {

            Console.WriteLine("Creating list of spells with one of each spells implemented...");

            List<Spell> spells = new List<Spell>();

            spells.Add(new JumpSpell());
            spells.Add(new LevelUpSpell());
            spells.Add(new ExplosionSpell());

            foreach (Spell spell in spells) {

                Console.WriteLine("\nCalling " + spell.GetType() + "'s Activate method\n");

                spell.Activate();
            }

            Console.WriteLine("\nPress enter to close tests...");
            Console.ReadLine();


        }
    }
}
