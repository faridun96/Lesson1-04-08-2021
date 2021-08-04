using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 16.80; 
            double b = 12.40;
            double result = Math.Sqrt(a*b);
            Console.WriteLine($"Среднее геометрическое = {Math.Round(result,2)}");    // 1 задание

            double A = 1.40;
            double B = -5.50;
            double C = 0.60;
            double AC = Math.Abs(A-C);
            double BC = Math.Abs(B-C);
            double Sum = Math.Abs(AC+BC);
            Console.WriteLine($"Длина отрезков AC = {Math.Round(AC,2)}");
            Console.WriteLine($"Длины отрезков BC = {Math.Round(BC,2)}");
            Console.WriteLine($"Сумма = {Math.Round(Sum,2)}"); // 2 задание

            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;
            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
            Console.WriteLine($"Расстояние между двумя точками = {Math.Round(dist,2)}");  // 3 задание

            int number = 41;
            int chislo = (number/10)+(number%10)*10;
            Console.WriteLine($"Двузначное число = {(chislo)}"); // 4 задание

            int N = 10985;
            int minuta = N/60;
            Console.WriteLine($"Количество целых минут = {(minuta)}"); // 5 задание

            int K = 202;
            int Day = (K%7);
            Console.WriteLine($"Номер дня недели для K-го дня года, = {(Day)}"); // 6 задание
        }
    }
}
