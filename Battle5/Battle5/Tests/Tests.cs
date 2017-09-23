using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle5 {
    class Tests {
        static void Main(string[] args) {


            Console.WriteLine("Creating object pool with a max of 100 slots...");

            VertexPool vertPool = new VertexPool();

            Console.WriteLine(vertPool.ToString());

            Console.WriteLine("\nPopulating the object pool with 75 objects...");

            for (int i = 0; i < 75; i++) {

                vertPool.addVertex();

            }

            Console.WriteLine(vertPool.ToString());

            Console.WriteLine("\nCalling act on 75 objects where some randomly become not in use...");

            vertPool.enact();

            Console.WriteLine(vertPool.ToString());

            Console.WriteLine("\nCalling act again...");

            vertPool.enact();

            Console.WriteLine(vertPool.ToString());

            Console.WriteLine("\nTrying to populate the object pool with more than can fit...");

            for (int i = 0; i < 101; i++) {

                vertPool.addVertex();

            }

            Console.WriteLine(vertPool.ToString());

            Console.WriteLine("\nActing items in object pool 4 times in a row...");

            vertPool.enact();
            vertPool.enact();
            vertPool.enact();
            vertPool.enact();

            Console.WriteLine(vertPool.ToString());

            Console.WriteLine("\nFinal object list:");

            Console.WriteLine(vertPool.getInfo());


            Console.WriteLine("\nPress enter to close the test...");

            Console.ReadLine(); // Wait




        }



    }
}
