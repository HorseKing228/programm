using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите окружность: ");
        int rad = Convert.ToInt32(Console.ReadLine());
        int size = 2 * rad + 1;
        int center = rad;
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                double dist = Math.Sqrt(Math.Pow(x - center, 2) + Math.Pow(y - center, 2));
                if (Math.Abs(dist - rad) < 0.7)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}