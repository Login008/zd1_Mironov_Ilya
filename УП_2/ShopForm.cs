using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_2
{
    public partial class ShopForm :Form
    {
        Shop pyaterocka;
        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            pyaterocka = new Shop(); //инициализация магазина
            label4.Text = pyaterocka.salary.ToString();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            try //проверка на введение чисел
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") //проверка на пустоту
                {
                    if (double.Parse(textBox2.Text) > 0) //проверка на количество
                    {
                        if (int.Parse(textBox3.Text) > 0) //ещё одна проверка на количество
                        {
                            pyaterocka.CreateProduct(textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text)); //добавляем продукт
                            MessageBox.Show("Товар был успешно добавлен");
                            textBox1.Text = ""; //очищаем текстбоксы
                            textBox2.Text = "";
                            textBox3.Text = "";
                            listBox1.Items.Clear(); //очищаем листбокс
                            listBox1 = pyaterocka.WriteAllProducts(listBox1); //выводим все продукты в листбокс
                        }
                        else
                            MessageBox.Show("Количество товара не может быть отрицательным или равно нулю");
                    }
                    else
                        MessageBox.Show("Товар не может быть бесплатным или его цена быть отрицательной");
                }
                else
                    MessageBox.Show("Заполните все поля для добавления продукта");
            }
            catch
            {
                MessageBox.Show("В цене или количестве были использованы не числа, товар не был добавлен");
            }
        }

        private void addInBasket_Click(object sender, EventArgs e)
        {
            try //проверка на выбор товара
            {
                string[] name = listBox1.Items[listBox1.SelectedIndex].ToString().Split('~'); //берём товар из 1-го листбокса
                Product product = pyaterocka.FindByName(name[0]); //ищем его в словаре
                listBox2.Items.Add($"{product.Name}~{product.Price}"); //добавляем во 2-ой листбокс
            }
            catch
            {
                MessageBox.Show("Товар не выбран");
            }
        }

        private void sellBut_Click(object sender, EventArgs e)
        {
            foreach (var tovar in listBox2.Items) //перебираем элементы во 2-ом листбоксе и продаём всё из корзины
            {
                string[] name = tovar.ToString().Split('~');
                pyaterocka.Sell(name[0]);
            }
            label4.Text = pyaterocka.salary.ToString(); //обновляем прибыль
            listBox2.Items.Clear(); //очищаем корзину
            listBox1.Items.Clear(); //очищаем 1-ый листбокс
            listBox1 = pyaterocka.WriteAllProducts(listBox1); //обновляем товары в наличии
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1) //проверка на выбранный товар
                listBox2.Items.RemoveAt(listBox2.SelectedIndex); //удаляем элемент из корзины
            else
                MessageBox.Show("Товар не выбран");
        }
    }
}
