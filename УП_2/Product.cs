using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_2
{
    class Product
    {
        public double Price { get; set; } //свойства продукта
        public string Name { get; set; }

        public Product(string Name, double Price) //конструктор
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string GetInfo() //отображение информации
        {
            return Name + "~" + Price;
        }
    }
}
