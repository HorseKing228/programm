using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x [-1, 1]: ");
        double x = Convert.ToDouble(Console.ReadLine());
        if (x < -1 || x > 1)
        {
            Console.WriteLine("X должен быть в [-1, 1]");
            return;
        }
        double res = 1;
        double term = 1;
        int f = 1;
        while (Math.Abs(term) >= 1e-6)
        {
            term *= x / f;
            res += term;
            f++;
        }
        Console.WriteLine($"Примерное e^{x}: {res}");
    }
}