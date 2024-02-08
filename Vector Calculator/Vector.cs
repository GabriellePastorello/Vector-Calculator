using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            // square root of x^2 + y^2
            float squareX = x * x;
            float squareY = y * y;
            float squareZ = z * z;
            //gets x squared, y squared and z squared
            float mag = squareX + squareY + squareZ;
            mag = MathF.Sqrt(mag);
            //adds the x, y and z and square roots them
            return mag;
        }

        public float GetDirection()
        {
            // theta = atan (y/x)
            return MathF.Atan(y / x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            //adds the x,y, and z values of two vectors
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
            //turns each value of the vector into negative if the value is positive, or positive if the value is negative
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            //subtracts the x, y, and z values of two vectors
        }

        public static Vector Scale(Vector v, float s)
        {
            //scales vector by s by multiplying x, y and z by s
            return new Vector(v.x * s, v.y * s, v.z * s);
        }

        public static Vector Normalize(Vector v)
        {
            // divide x, y and z by the magnitude
            float magnitude = v.GetMagnitude();
            return new Vector(v.x / magnitude, v.y / magnitude, v.z / magnitude);
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            // dot product = (AX * BX) + (AY * BY) + (AZ * BZ)
            float xProduct = v1.x * v2.x;
            float yProduct = v1.y * v2.y;
            float zProduct = v1.z * v2.z;
            return xProduct + yProduct + zProduct;
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // Cx = EyAz - EzAy
            //Cy = EzAx - ExAz
            //Cz = ExAy - EyAx
            float Cx = (v1.y * v2.z) - (v1.z * v2.y);
            float Cy = (v1.z * v2.x) - (v1.x * v2.z);
            float Cz = (v1.x * v2.y) - (v1.y * v2.x);
            return new Vector(Cx, Cy, Cz);
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            // Theta = acos (dotProduct/magnitudeA * magnitudeB)
            float numerator = DotProduct(v1, v2);
            float denominator = v1.GetMagnitude() * v2.GetMagnitude();
            return MathF.Acos(numerator / denominator);
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // proj (V) U = dot product/ (magnitude of v) squared
            float dotProd = Vector.DotProduct(v1, v2);
            float magnitude = v2.GetMagnitude();
            magnitude = MathF.Pow(magnitude, 2);
            float scalar = dotProd / magnitude;
            return Vector.Scale(v2, scalar);
        }
    }
}
