using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboration_on_git
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Меню выбора:");
                Console.WriteLine("1. Ввести число A");
                Console.WriteLine("2. Ввести число B");
                Console.WriteLine("3. Выполнить операцию '+'");
                Console.WriteLine("4. Выполнить операцию '-'");
                Console.WriteLine("5. Выполнить операцию '*'");
                Console.WriteLine("6. Выполнить операцию '/'");
                Console.WriteLine("7. Выйти из программы");

                Console.Write("Введите номер пункта меню: ");
                string choice = Console.ReadLine();
                Console.Write("Введите a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(b);
                        break;
                    case "2":
                        Console.WriteLine(b);
                        break;
                    case "3":
                        Console.WriteLine($"Результат сложения: {a + b}");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine($"Результат вычитания: {a - b}");
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine($"Результат умножения: {a * b}");
                        Console.WriteLine();
                        break;
                    case "6":
                        if (b != 0)
                            Console.WriteLine($"Результат деления: {(double)a / b}");
                        else
                            Console.WriteLine("Деление на ноль невозможно!");
                        Console.WriteLine();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод!");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
