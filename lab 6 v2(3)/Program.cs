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
