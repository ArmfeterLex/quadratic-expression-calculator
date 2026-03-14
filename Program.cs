using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два любых числа");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = Math.Round((x*x)+x*y-(y*y), 2);
        Console.WriteLine("Квадратичное вычитание значений Х и У = {0:f2}", z);
        Console.ReadKey();
    }
}
