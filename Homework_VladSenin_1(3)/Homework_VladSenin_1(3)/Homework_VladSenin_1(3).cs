using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Бесконечное количество решений");
                }
                else
                {
                    Console.WriteLine("Нет решений");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Одно решение: x = {x}");
            }
        }
        else
        {
            double discr = b * b - 4 * a * c;
            if (discr > 0)
            {
                double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine($"Два решения: x1 = {x1}, x2 = {x2}");
            }
            else if (discr == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Одно решение: x = {x}");
            }
            else
            {
                Console.WriteLine("Нет решений");
            }
        }
    }
}