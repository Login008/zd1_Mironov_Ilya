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
            pyaterocka = new Shop();
            label4.Text = pyaterocka.salary.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    if (double.Parse(textBox2.Text) > 0)
                    {
                        if (int.Parse(textBox3.Text) > 0)
                        {
                            pyaterocka.CreateProduct(textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text));
                            MessageBox.Show("Товар был успешно добавлен");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            listBox1.Items.Clear();
                            listBox1 = pyaterocka.WriteAllProducts(listBox1);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] name = listBox1.Items[listBox1.SelectedIndex].ToString().Split('~');
                Product product = pyaterocka.FindByName(name[0]);
                listBox2.Items.Add($"{product.Name}~{product.Price}");
            }
            catch
            {
                MessageBox.Show("Товар не выбран");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var tovar in listBox2.Items)
            {
                string[] name = tovar.ToString().Split('~');
                pyaterocka.Sell(name[0]);
                label4.Text = pyaterocka.salary.ToString();
            }
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            listBox1 = pyaterocka.WriteAllProducts(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            else
                MessageBox.Show("Товар не выбран");
        }
    }
}
