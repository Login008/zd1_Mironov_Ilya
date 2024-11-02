using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("", 0); //инициализируем объект
            Console.ForegroundColor = ConsoleColor.Green; //красим цвет текста в зелёный
            while (true) // Бесконечный цикл для работы меню
            {
                    try
                    {
                        Console.WriteLine("\nВыберите пункт меню, написав цифру:\n1 Заполнить данные кота\n2 Вывести информацию о коте\n3 Завершить работу");
                        var answer = Console.ReadKey(); // читаем ответ

                        switch (answer.KeyChar)
                        {
                            case '1': // 1 пункт
                                Console.Write("\nИмя кота: ");
                                string name = Console.ReadLine();
                                Console.Write("Вес кота: ");
                                double weight = Double.Parse(Console.ReadLine());
                                cat = new Cat(name, weight); // Меняем поля кота

                                break;
                            case '2': // 2 пункт
                                cat.Meow(); // Вывод информации

                                break;
                            case '3': // 3 пункт
                                Console.WriteLine("\nРабота завершена");
                                Console.ReadKey();
                                return;
                            default: // на случай любой другой клавиши
                                Console.WriteLine("\nТакого пункта в меню нет, попробуйте ещё раз");
                                break;
                        }
                    }
                    catch // на случай, если в вес будет введено не число
                    {
                        Console.WriteLine("\nВведите число, а не что-либо другое");
                    }
                Console.ReadKey();
                Console.Clear(); //Очищаем текст в консоли
            }
        }
    }
}
