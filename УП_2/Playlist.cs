using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_2
{
    struct Song //структура песни
    {
        public string Author;
        public string Title;
        public string Filename;
    }
    class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist() //конструктор
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public List<Song> List { //свойство списка
            get { return list; }
            set { list = value; }
        }

        public Song CurrentSong() //возвращение выбранной песни
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void AddSong(string Author, string Title, string Filename) //Добавить песню в плейлист через ввод автора, название песни и название файла
        {
            Song song = new Song();
            song.Author = Author;
            song.Title = Title;
            song.Filename = Filename;
            AddSong(song);
        }
        public void AddSong(Song song) //Добавить песню через ввод уже созданной структуры
        {
            list.Add(song);
        }
        public void Clear() //очистка плейлиста
        {
            list.Clear();
        }
        public Song NextSong() //выбор следующей песни
        {
            if (currentIndex < list.Count - 1)
            {
                currentIndex++;
            }
            else
                currentIndex = 0;
            return CurrentSong();
        }
        public Song PreviousSong() //выбор предыдущей песни
        {
            if (currentIndex > 0)
                currentIndex--;
            else
                currentIndex = list.Count - 1;
            return CurrentSong();
        }
        public Song ByIndex(int index) //выбор песни по введённому индексу
        {

            if (index >= 0 && list.Count > index)
            {
                currentIndex = index;
                return CurrentSong();
            }
            else
                throw new IndexOutOfRangeException("Такой аудиозаписи нет в плейлисте");
        }
        public Song TransitionToBegin() //переход к началу списка
        {
            currentIndex = 0;
            return CurrentSong();
        }
        public void DeleteSong(int index) //удаление песни по индексу
        {
            if (index >= 0 && index < list.Count)
                list.RemoveAt(index);
            else
                throw new IndexOutOfRangeException("Такой аудиозаписи нет в плейлисте");
        }
        public void DeleteSong(Song song) //удаление песни по совпадению структур в списке
        {
            foreach (var item in list)
            {
                if (item.Author == song.Author && item.Title == song.Title && item.Filename == song.Filename)
                {
                    list.Remove(item);
                    PreviousSong();
                    return;
                }
            }
            throw new Exception("Данная аудиозапись не найдена в плейлисте");
        }
    }
}
