using System;
using System.Globalization;

namespace ConsoleApp26
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество строк: ");               
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int m = Convert.ToInt32(Console.ReadLine());
                if (n > 1 && m > 1)
                {
                    mas ms = new mas(n,m);
                    int[,] IntArray = ms.Input();
                    Console.WriteLine("Матрица: ");
                    ms.Output();
                    Console.WriteLine("Перегрузка ++: ");
                    ms++;
                    ms.Output();
                    Console.WriteLine("Перегрузка --: ");
                    ms--;
                    ms.Output();
                    Console.Write("Введите номер номер строки для обращения к элементу: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите номер номер столбца для обращения к элементу: ");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(ms[i, j]);
                    Console.WriteLine();
                    Console.WriteLine("Перегрузка констант true/false\nМатрица является квадратной:");
                    if (ms)
                        Console.WriteLine(true);
                    else
                        Console.WriteLine(false);
                    Console.WriteLine();
                    Console.Write("Введите количество строк: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество столбцов: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a == n && b == m)
                    {
                        mas ms1 = new mas(a, b);
                        int[,] IntArray1 = ms1.Input();
                        Console.WriteLine("Матрица: ");
                        ms1.Output();

                        mas ms2 = ms + ms1;
                        Console.WriteLine("Сумма двух матриц: ");
                        ms2.Output();
                    }
                    else { throw new Exception("Матрицы имеют разную размерность, нельзя сложить!"); }
                    int[,] s = (int[,])ms;
                    Console.WriteLine(s);
                    mas p = (mas)ms;
                    ms.Output();
                }
                else { throw new Exception("Число должно быть больше единицы!"); }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Некорректный ввод! {ex.Message}");
            }

        }
    }
}
