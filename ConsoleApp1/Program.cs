using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static int min(int x, int y)
        {
            return (x > y) ? y : x;
        }
        public static double min(double x, double y)
        {
            return (x > y) ? y : x;
        }
        public static int pow(int x, int y)
        {
            int result = 1;
            while (y>0)
            {
                result *= x;
                y--;
            }
            return result;
        }

        public static double abs(double x)
        {
            return x < 0 ? -x : x;
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1| минимальное значение из четырех чисел");
            Console.WriteLine("2| целочисленное x в положительную степень y");
            Console.WriteLine("3| получить модуль числа");
            Console.WriteLine("4| выход");
            try
            {
                int key = Int16.Parse(Console.ReadLine());
                switch(key)
                {
                    case 1:
                        {
                            Console.WriteLine("\t 1| Целочисленные");
                            Console.WriteLine("\t 2| Вещественные");

                            int func_key = Int16.Parse(Console.ReadLine());
                            switch (func_key)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("\t\t Введите число a");
                                        int a = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("\t\t Введите число b");
                                        int b = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("\t\t Введите число c");
                                        int c = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("\t\t Введите число d");
                                        int d = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Минимально число = " + min(min(a, b), min(c, d)));
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("\t\t Введите число a");
                                        double a = Double.Parse(Console.ReadLine());
                                        Console.WriteLine("\t\t Введите число b");
                                        double b = Double.Parse(Console.ReadLine());
                                        Console.WriteLine("\t\t Введите число c");
                                        double c = Double.Parse(Console.ReadLine());
                                        Console.WriteLine("\t\t Введите число d");
                                        double d = Double.Parse(Console.ReadLine());
                                        Console.WriteLine("Минимально число = " + min(min(a, b), min(c, d)));
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\t Введите число x");
                            int a = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("\t Введите число y");
                            int b = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(pow(a,b));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\t Введите число");
                            Console.WriteLine(abs(Double.Parse(Console.ReadLine())));
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Такой функции нет");
                            break;
                        }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            Menu();
        }
    }
}
