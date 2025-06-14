using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите строку S: ");
        string S = Console.ReadLine();
        Console.Write("Введите строку S1: ");
        string S1 = Console.ReadLine();
        if (S.Length == 0 || S1.Length == 0 || S1.Length > S.Length)
        {
            Console.WriteLine("Ввод ложный!");
            return;
        }
        int count = 0;
        for (int i = 0; i <= S.Length - S1.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < S1.Length; j++)
            {
                if (S[i + j] != S1[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
        }
        Console.WriteLine($"Сколько раз входит: {count}");
    }
}