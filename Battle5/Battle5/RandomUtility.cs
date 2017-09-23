using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle5 {

    // I had to make a static random utility class because the Random object in C# was being absolutely unuseable
    static class RandomUtility {

        public static int notBrokenRandomNum() {
            //I can't believe how annoying this problem was, StackOverflow to the rescue:
            //https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c
            using (System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider()) {
                byte[] randomNumber = new byte[4];//4 for int32
                rng.GetBytes(randomNumber);
                int value = BitConverter.ToInt32(randomNumber, 0);
                return value;
            }

        }

    }
}
