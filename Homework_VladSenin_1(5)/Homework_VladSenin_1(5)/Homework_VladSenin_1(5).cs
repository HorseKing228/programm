using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длины сторон первого треугольника:");
        double a1 = ReadPositiveNumber("Сторона 1: ");
        double b1 = ReadPositiveNumber("Сторона 2: ");
        double c1 = ReadPositiveNumber("Сторона 3: ");
        Console.WriteLine("Введите длины сторон второго треугольника:");
        double a2 = ReadPositiveNumber("Сторона 1: ");
        double b2 = ReadPositiveNumber("Сторона 2: ");
        double c2 = ReadPositiveNumber("Сторона 3: ");
        if (!Triangle(a1, b1, c1) || !Triangle(a2, b2, c2))
        {
            Console.WriteLine("Данные значения не могут образовать треугольник");
            return;
        }
        SortSides(ref a1, ref b1, ref c1);
        SortSides(ref a2, ref b2, ref c2);
        bool areSimilar = Similarity(a1, b1, c1, a2, b2, c2);
        Console.WriteLine(areSimilar ? "да" : "нет");
    }
    static double ReadPositiveNumber(string prompt)
    {
        double number;
        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out number) || number <= 0);
        return number;
    }
    static bool Triangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    static void SortSides(ref double a, ref double b, ref double c)
    {
        if (a > b) Swap(ref a, ref b);
        if (b > c) Swap(ref b, ref c);
        if (a > b) Swap(ref a, ref b);
    }
    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y;
        y = temp;
    }
    static bool Similarity(double a1, double b1, double c1, double a2, double b2, double c2)
    {
        double ratio1 = a1 / a2;
        double ratio2 = b1 / b2;
        double ratio3 = c1 / c2;
        const double epsilon = 1e-10;
        return Math.Abs(ratio1 - ratio2) < epsilon && Math.Abs(ratio1 - ratio3) < epsilon;
    }
}