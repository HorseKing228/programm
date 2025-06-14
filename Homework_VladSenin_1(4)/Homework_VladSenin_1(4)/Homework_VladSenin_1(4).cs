using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три целых числа:");
        Console.Write("Первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Третье число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            int bitA = (a >> i) & 1;
            int bitB = (b >> i) & 1;
            int bitC = (c >> i) & 1;
            int ones = bitA + bitB + bitC;
            if (ones >= 2)
            {
                res |= (1 << i);
            }
        }
        Console.WriteLine($"Результат: {res}");
        Console.WriteLine($"Представление в двоичном коде: {Convert.ToString(res, 2).PadLeft(32, '0')}");
    }
}