using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FrogKnightMonoGL
{
    static class CollisionDetection
    {
        /**
            <summary>
            Return a true value if the distance between two objects is within a certain threshold.
            </summary>
        */
        public static bool areColliding(GameEntity a, GameEntity b)
        {
            Position p1 = a.MyPosition;
            Position p2 = b.MyPosition;

            Debug.WriteLine("Checking for collision.");
            float distance = distanceBetween(p1, p2);

            Debug.WriteLine("The distance between the objects is " + distance);

            if (distance < 100.0f /* magic number for testing*/)
            {
                Debug.WriteLine("Colliding with object.");
                return true;
            }

            return false;
        }


        /**
            <summary>
            Find the euclidean distance between two two-dimensional points.  Return a float value.
            </summary>
        */
        private static float distanceBetween(Position p1, Position p2)
        {
            return (float)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }

    }
}
