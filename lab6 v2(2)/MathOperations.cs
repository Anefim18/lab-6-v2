using System;

public class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int[] Add(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            throw new ArgumentException("Arrays must have the same length.");

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

    public static int[,] Add(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        if (rows != matrix2.GetLength(0) || columns != matrix2.GetLength(1))
            throw new ArgumentException("Matrices must have the same dimensions.");

        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double[] Add(double[] array1, double[] array2)
    {
        if (array1.Length != array2.Length)
            throw new ArgumentException("Arrays must have the same length.");

        double[] result = new double[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

    // Додайте інші перевантажені методи для віднімання, множення та інших операцій

    public static void Main()
    {
        // Приклад використання
        int sum1 = MathOperations.Add(5, 10);
        Console.WriteLine("Sum of two numbers: " + sum1);

        int[] arraySum = MathOperations.Add(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
        Console.WriteLine("Sum of two arrays: " + string.Join(", ", arraySum));

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        int[,] matrixSum = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine("Sum of two matrices:");
        for (int i = 0; i < matrixSum.GetLength(0); i++)
        {
            for (int j = 0; j < matrixSum.GetLength(1); j++)
            {
                Console.Write(matrixSum[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Перевантажені методи для дійсних чисел
        double doubleSum = MathOperations.Add(3.14, 2.71);
        Console.WriteLine("Sum of two doubles: " + doubleSum);

        double[] doubleArraySum = MathOperations.Add(new double[] { 1.1, 2.2, 3.3 }, new double[] { 4.4, 5.5, 6.6 });
        Console.WriteLine("Sum of two double arrays: " + string.Join(", ", doubleArraySum));
    }
}
