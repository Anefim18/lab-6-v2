using System;

public class Quaternion
{
    public double W { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    public double Norm()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    public Quaternion Inverse()
    {
        double normSquared = W * W + X * X + Y * Y + Z * Z;
        if (normSquared == 0)
            throw new InvalidOperationException("Cannot invert a quaternion with zero norm.");

        double reciprocal = 1 / normSquared;
        return new Quaternion(W * reciprocal, -X * reciprocal, -Y * reciprocal, -Z * reciprocal);
    }

    public static Quaternion operator +(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W + q2.W, q1.X + q2.X, q1.Y + q2.Y, q1.Z + q2.Z);
    }

    public static Quaternion operator -(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
    }

    public static Quaternion operator *(Quaternion q1, Quaternion q2)
    {
        double w = q1.W * q2.W - q1.X * q2.X - q1.Y * q2.Y - q1.Z * q2.Z;
        double x = q1.W * q2.X + q1.X * q2.W + q1.Y * q2.Z - q1.Z * q2.Y;
        double y = q1.W * q2.Y - q1.X * q2.Z + q1.Y * q2.W + q1.Z * q2.X;
        double z = q1.W * q2.Z + q1.X * q2.Y - q1.Y * q2.X + q1.Z * q2.W;

        return new Quaternion(w, x, y, z);
    }

    public static bool operator ==(Quaternion q1, Quaternion q2)
    {
        return q1.W == q2.W && q1.X == q2.X && q1.Y == q2.Y && q1.Z == q2.Z;
    }

    public static bool operator !=(Quaternion q1, Quaternion q2)
    {
        return !(q1 == q2);
    }

    public double[,] ToRotationMatrix()
    {
        double[,] matrix = new double[3, 3];

        matrix[0, 0] = 1 - 2 * (Y * Y + Z * Z);
        matrix[0, 1] = 2 * (X * Y - W * Z);
        matrix[0, 2] = 2 * (X * Z + W * Y);

        matrix[1, 0] = 2 * (X * Y + W * Z);
        matrix[1, 1] = 1 - 2 * (X * X + Z * Z);
        matrix[1, 2] = 2 * (Y * Z - W * X);

        matrix[2, 0] = 2 * (X * Z - W * Y);
        matrix[2, 1] = 2 * (Y * Z + W * X);
        matrix[2, 2] = 1 - 2 * (X * X + Y * Y);

        return matrix;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Quaternion other = (Quaternion)obj;
        return W == other.W && X == other.X && Y == other.Y && Z == other.Z;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(W, X, Y, Z);
    }

    public override string ToString()
    {
        return $"({W}, {X}, {Y}, {Z})";
    }
}

class Program
{
    static void Main()
    {
        Quaternion q1 = new Quaternion(1, 2, 3, 4);
        Quaternion q2 = new Quaternion(5, 6, 7, 8);

        Console.WriteLine("Quaternion 1: " + q1);
        Console.WriteLine("Quaternion 2: " + q2);

        Quaternion sum = q1 + q2;
        Console.WriteLine("Sum: " + sum);

        Quaternion difference = q1 - q2;
        Console.WriteLine("Difference: " + difference);

        Quaternion product = q1 * q2;
        Console.WriteLine("Product: " + product);

        double norm = q1.Norm();
        Console.WriteLine("Norm of Quaternion 1: " + norm);

        Quaternion conjugate = q1.Conjugate();
        Console.WriteLine("Conjugate of Quaternion 1: " + conjugate);

        Quaternion inverse = q1.Inverse();
        Console.WriteLine("Inverse of Quaternion 1: " + inverse);

        bool areEqual = q1 == q2;
        Console.WriteLine("Quaternion 1 and Quaternion 2 are equal: " + areEqual);

        double[,] rotationMatrix = q1.ToRotationMatrix();
        Console.WriteLine("Rotation Matrix for Quaternion 1:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(rotationMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
