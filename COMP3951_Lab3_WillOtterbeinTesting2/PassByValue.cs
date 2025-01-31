using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    struct Vector(float iX, float iY)
    {
        public float x = iX;
        public float y = iY;
        override public string ToString()
        {
            return $"({x},{y})";
        }
    }

    class Vector3(float iX, float iY, float iZ)
    {
        public float x = iX;
        public float y = iY;
        public float z = iZ;

        override public string ToString()
        {
            return $"({x},{y},{z})";
        }
    }

    class VectorOperations
    {
        /// <summary>
        /// Add vector1 to vector2. 2D Vectors.
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        public static void VectorAdd2D(Vector vector1, Vector vector2)
        {
            vector1.x += vector2.x;
            vector1.y += vector2.y;
        }

        /// <summary>
        /// Add vector1 to vector2. 2D Vectors.
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        public static void VectorAdd3D(Vector3 vector1, Vector3 vector2)
        {
            vector1.x += vector2.x;
            vector1.y += vector2.y;
            vector1.z += vector2.z;
        }

        public static void Test()
        {
            // Recall that in C#, all things are pass by value...
            Vector myVector = new(10.5f, 11.2f);
            Vector myOtherVector = new(5.0f, 2.4f);
            Vector3 myVector3 = new(10, 10, 15);
            Vector3 myOtherVector3 = new(10, 15, 20);

            // What is the output ?
            Console.WriteLine($"2D Vectors\n----------\n{myVector}, {myOtherVector}");
            VectorOperations.VectorAdd2D(myVector, myOtherVector);
            Console.WriteLine($"2D Vectors after operation\n----------\n{myVector}, {myOtherVector}");
            Console.WriteLine();

            // What is the output ?
            Console.WriteLine($"3D vectors\n----------\n{myVector3}, {myOtherVector3}");
            VectorOperations.VectorAdd3D(myVector3, myOtherVector3);
            Console.WriteLine($"3D Vectors after operation\n----------\n{myVector3}, {myOtherVector3}");
            Console.WriteLine();
        }
    }
}
