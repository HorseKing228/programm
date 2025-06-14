using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b:");
        int b = Convert.ToInt32(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("Делить на ноль нельзя!");
            return;
        }
        int res = 0;
        int rem = Math.Abs(a);
        int absB = Math.Abs(b);
        while (rem >= absB)
        {
            rem -= absB;
            res++;
        }
        if ((a < 0 && b > 0) || (a > 0 && b < 0))
        {
            res = -res;
        }
        if (a < 0)
        {
            rem = -rem;
        }
        Console.WriteLine($"Целая часть: {res}, остаток: {rem}");
    }
}