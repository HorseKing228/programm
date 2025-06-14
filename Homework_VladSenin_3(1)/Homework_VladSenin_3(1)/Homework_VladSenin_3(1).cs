using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        string binaryA = Convert.ToString(a, 2).PadLeft(8, '0');
        string binaryB = Convert.ToString(b, 2).PadLeft(8, '0');
        Console.WriteLine($"\n{a} в двоичном коде: {binaryA}");
        Console.WriteLine($"{b} в двоичном коде: {binaryB}");
        string sumBinary = Binary(binaryA, binaryB);
        Console.WriteLine("\nРезультат сложения:");
        Console.WriteLine(sumBinary);
        int sum = Convert.ToInt32(sumBinary, 2);
        Console.WriteLine($"\nВ десятичном виде: {sum}");
    }
    static string Binary(string a, string b)
    {
        char[] res = new char[8];
        int carry = 0;
        for (int i = 7; i >= 0; i--)
        {
            int sum = (a[i] - '0') + (b[i] - '0') + carry;
            res[i] = (sum % 2 == 1) ? '1' : '0';
            carry = sum > 1 ? 1 : 0;
        }
        return new string(res);
    }
}