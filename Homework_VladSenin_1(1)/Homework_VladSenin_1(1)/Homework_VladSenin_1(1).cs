using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }
    static bool IsPrime(int num)
    {
        if (num <= 1) 
        { 
            return false; 
        }
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}