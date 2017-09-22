using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2 {

    public class Time{

        public static float deltaTime;
        
    }

    class Float3 {

        public float x, y, z;

        public static Float3 up = new Float3(0,1,0);
        public static Float3 right = new Float3(1, 0, 0);
        public static Float3 forward = new Float3(0, 0, 1);
        public static Float3 zero = new Float3(0, 0, 0);

        public Float3() {
            x = y = z = 0;
        }

        public Float3(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Float3(Float3 other) {
            this.x = other.x;
            this.y = other.y;
            this.z = other.z;
        }

        public static Float3 operator +(Float3 a, Float3 b) {
            return new Float3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Float3 operator *(Float3 a, float b) {
            return new Float3(a.x * b, a.y * b, a.z * b);
        }

    }

}
