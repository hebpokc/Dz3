using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        enum DayOfTheWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.Write("Введите 10 чисел: ");
            int[] numbers = new int[10];
            bool check = true;
            for (int i = 0; i < 10;)
            {
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Введено не число или дробное число");
                }
                else
                {
                    i++;
                }
            }
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    Console.WriteLine($"\nПоследовательность не возрастающая\nЧисло, нарушающее последовательнось - {numbers[i + 1]} под №{i + 2}");
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("\nПоследовательнось возрастающая");
            }

            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Введите число от 6 до 14: ");
            byte cardNum;
            try
            {
                while (!byte.TryParse(Console.ReadLine(), out cardNum))
                {
                    throw new Exception();
                }
                switch (cardNum)
                {
                    case 6:
                        {
                            Console.WriteLine("\nВаша карта - Шестерка");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\nВаша карта - Семерка");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("\nВаша карта - Восьмерка");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("\nВаша карта - Девятка");
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("\nВаша карта - Десятка");
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("\nВаша карта - Валет");
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("\nВаша карта - Дама");
                            break;
                        }
                    case 13:
                        {
                            Console.WriteLine("\nВаша карта - Король");
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("\nВаша карта - Туз");
                            break;
                        }
                    default:
                        {
                            throw new Exception();
                        }
                }
            }
            catch (Exception)
            {
                Console.Write("\nВы ввели не число или ваше число меньше 6 / больше 14.");
            }

            Console.WriteLine("\nЗадание 3");
            Console.Write("Введите кто вы: ");
            switch (Console.ReadLine().ToLower())
            {
                case "jabroni":
                    {
                        Console.WriteLine("Patron Tequila");
                        break;
                    }
                case "school counselor":
                    {
                        Console.WriteLine("\nAnything with Alcohol");
                        break;
                    }
                case "programmer":
                    {
                        Console.WriteLine("\nHipster Craft Beer");
                        break;
                    }
                case "bike gang member":
                    {
                        Console.WriteLine("\nMoonshine");
                        break;
                    }
                case "politician":
                    {
                        Console.WriteLine("\nYour tax dollars");
                        break;
                    }
                case "rapper":
                    {
                        Console.WriteLine("\nCristal");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nBeer");
                        break;
                    }
            }

            Console.WriteLine("\nЗадание 4");
            Console.Write("Введите порядковый номер дня недели: ");
            try
            {
                byte day;
                if (!byte.TryParse(Console.ReadLine(), out day) || (day < 1 || day > 7))
                {
                    throw new Exception();
                }
                switch (day)
                {
                    case 1:
                        {
                            Console.WriteLine($"\nНомер {day} - это {(DayOfTheWeek)day}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"\nНомер {day} - это {(DayOfTheWeek)day}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"\nНомер {day} - это {(DayOfTheWeek)day}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"\nНомер {day} - это {(DayOfTheWeek)day}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"\nНомер {day} - это {(DayOfTheWeek)day}");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"\nНомер {day} - это {(DayOfTheWeek)day}");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine($"\nНомер {day} - это {(DayOfTheWeek)day}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nВы ввели чило меньше 1 или больше 7!");
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Console.Write("\nВы ввели не число");
            }

            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Программа считает количество кукол Barbie/Kitty");
            string[] dolls = { "doll", "barbie", "barbie doll", "hello", "kitty", "Hello Kitty" };
            int count = 0;
            Console.WriteLine();
            foreach (string d in dolls)
            {
                Console.WriteLine(d);
                d.ToLower();
                if (d == "barbie doll" || d == "Hello Kitty")
                {
                    count++;
                }
            }
            Console.WriteLine($"\n{count} куклы в сумке");
            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
