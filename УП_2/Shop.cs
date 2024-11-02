using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_2
{
    class Shop
    {
        private Dictionary<Product, int> products;
        public double salary = 0;

        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        public void CreateProduct(string name, double price, int count)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products.ElementAt(i).Key.Name == name)
                {
                    products.ElementAt(i).Key.Price = price;
                    products[products.ElementAt(i).Key] = count;
                    return;
                }
            }
            products.Add(new Product(name, price), count);
        }

        public ListBox WriteAllProducts(ListBox list1)
        {
            foreach (var product in products)
            {
                list1.Items.Add(product.Key.GetInfo() + "~" + product.Value + "\n");
            }
            return list1;
        }

        public void Sell(Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show($"Товара {product.Name} нет в наличии!");
                }
                else
                {
                    salary += product.Price;
                    products[product]--;
                }
            }
            else
            {
                MessageBox.Show($"Товар {product.Name} не найден!");
            }
        }
        public void Sell(string ProductName)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell);
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }

        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (name == product.Name)
                {
                    return product;
                }
            }
            return null;
        }

    }
}
