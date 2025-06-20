using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размерность ввиде нечётного числа: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("Кому говорю, нечётное число!");
            return;
        }
        int[,] matrix = new int[n, n];
        int value = 1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = value++;
        Console.WriteLine("\nМассив:");
        Matrix(matrix);
        Console.WriteLine("\nОбход по спирали:");
        Spiral(matrix);
    }
    static void Spiral(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int center = n / 2;
        int x = center, y = center;
        Console.Write(matrix[x, y] + " ");
        for (int step = 1; step < n; step++)
        {
            for (int i = 0; i < step; i++)
            {
                y++;
                if (y < n) Console.Write(matrix[x, y] + " ");
            }
            for (int i = 0; i < step; i++)
            {
                x--;
                if (x >= 0) Console.Write(matrix[x, y] + " ");
            }
            step++;
            for (int i = 0; i < step; i++)
            {
                y--;
                if (y >= 0) Console.Write(matrix[x, y] + " ");
            }
            for (int i = 0; i < step; i++)
            {
                x++;
                if (x < n) Console.Write(matrix[x, y] + " ");
            }
        }
    }
    static void Matrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            Console.WriteLine();
        }
    }
}