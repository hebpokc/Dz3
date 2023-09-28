using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab4
{
    class Program
    {
        public static string IsLeap(int year)
        {
            if (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
            {
                return "обычный год";
            }
            else
            {
                return "високосный год";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1, 4.2. Домашнее задание 4.1");
            Console.Write("Введите год: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("\nВы ввели не число. Повторите: ");
            }
            DateTime date = new DateTime(year, 1, 1);
            Console.Write("Введите число от 1 до 365: ");
            int day;
            try
            {
                while (!int.TryParse(Console.ReadLine(), out day))
                {
                    Console.Write("\nВы ввели не число. Повторите: ");
                }
                if (day > 0 && day <= 365)
                {
                    Console.WriteLine($"\n{year} - {IsLeap(year)}\nЧисло {day} - является {date.AddDays(day - 1).ToString("dd MMMM")}");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nНеверный ввод. Число меньше 1 или больше 365");
            }

            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
