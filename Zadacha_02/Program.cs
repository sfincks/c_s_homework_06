// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double insertNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

string crossLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    System.Console.WriteLine($"x = {x}");
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    // k1 * x + b1 == k2 * x + b2;
    // (k1 * x)-(k2 * x) = b2-b1
    // (k1-k2)*x = b2-b1
    // int x = (b2-b1)/(k1-k2);
    string coordinates = $"{y1},{y2}";
    return coordinates;
}

System.Console.WriteLine("Введите переменные для уравнений \"y = k1 * x + b1\" и \"y = k2 * x + b2\"");
double b1 = insertNumber("Введите число b1");
double k1 = insertNumber("Введите число k1");
double b2 = insertNumber("Введите число b2");
double k2 = insertNumber("Введите число k2");
System.Console.WriteLine($"Точка пересечения прямых находится по координатам ({crossLines(b1, k1, b2, k2)})");