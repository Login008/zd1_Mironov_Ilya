using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_2
{
    public partial class PlayListForm :Form
    {
        Playlist playlist;
        public PlayListForm()
        {
            InitializeComponent();
            playlist = new Playlist(); //инициализация плейлиста
        }

        public void ShowSongs() //метод для обновления списка аудио в листбоксе
        {
            listBox1.Items.Clear(); //очищаем список
            foreach (var item in playlist.List) //перебираем аудио в списке и добавляем в листбокс
            {
                listBox1.Items.Add($"{item.Author}~{item.Title}~{item.Filename}");
            }
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") //проверка на пустоту
            {
                playlist.AddSong(textBox1.Text, textBox2.Text, textBox3.Text); //добавление аудио
                ShowSongs();
                MessageBox.Show("Аудиозапись добавлена");
                textBox1.Text = ""; //очистка текстбоксов
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void goBackBut_Click(object sender, EventArgs e)
        {
            try
            {
                Song song = playlist.PreviousSong(); //получаем экземпляр предыдущего аудио
                label1.Text = $"Сейчас играет: {song.Title}\nИсполнитель: {song.Author}"; //отображение выбранного аудио
            }
            catch
            {
                MessageBox.Show("Плейлист пуст");
            }
        }

        private void goNextBut_Click(object sender, EventArgs e)
        {
            try
            {
                Song song = playlist.NextSong(); //получаем экземпляр следующего аудио
                label1.Text = $"Сейчас играет: {song.Title}\nИсполнитель: {song.Author}"; //отображение выбранного аудио
            }
            catch
            {
                MessageBox.Show("Плейлист пуст");
            }
        }

        private void beginBut_Click(object sender, EventArgs e)
        {
            try
            {
                Song song = playlist.TransitionToBegin(); //получаем экземпляр первого аудио
                label1.Text = $"Сейчас играет: {song.Title}\nИсполнитель: {song.Author}"; //отображение выбранного аудио
            }
            catch
            {
                MessageBox.Show("Плейлист пуст");
            }
        }

        private void playBut_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) //проверка на выделение элемента
            {
                Song song = playlist.ByIndex(listBox1.SelectedIndex); //находим песню и получаем экземпляр аудио
                label1.Text = $"Сейчас играет: {song.Title}\nИсполнитель: {song.Author}"; //отображение выбранного аудио
            }
            else
                MessageBox.Show("Песня не выбрана");
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) //проверка на выделение элемента
            {
                playlist.DeleteSong(listBox1.SelectedIndex); //удаление песни
                ShowSongs(); //обновление листбокса
            }
            else
                MessageBox.Show("Песня не выбрана");
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            playlist.Clear(); //очистка списка аудио
            ShowSongs(); //обновление списка аудио
            label1.Text = ""; //очистка лэйбла
            MessageBox.Show("Плейлист очищен");
        }
    }
}
