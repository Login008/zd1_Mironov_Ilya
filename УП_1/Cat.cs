using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_1
{
    class Cat // наш класс
    {
        private string name; // скрытые поля
        private double weight;
        public string Name // свойство, реализуем инкапсуляцию
        {

            get { return name; } // получение значения - просто возврат name
            set // установка значения - используем проверку
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value) // перебираем символы в имени и проверяем, являются ли они буквами
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                    name = value;
                else
                    Console.WriteLine($"\n{value} - неправильное имя!!!");
            }
        }

        public double Weight
        {
            get { return weight; } // возвращаем вес
            set
            {
                if (value > -1) // проверка на отрицательное или нулевое значение веса
                    weight = value;
                else
                    Console.WriteLine("\nВес не может быть отрицательным или нулевым");
            }
        }

        public Cat(string CatName, double CatWeight) // конструктор нашего класса, в котором мы задаём свойства
        {
            Name = CatName;
            Weight = CatWeight;
        }

        public void Meow() // получаем информацию о коте
        {
            if (name != "" && weight != 0) //проверка на пустые поля
                Console.WriteLine($"\n{name}: МЯЯЯЯУ!!!!\n( Вес кота = {weight} )\n");
            else
                Console.WriteLine("\nОдно или оба поля не инициализированы\n");
        }

    }
}
