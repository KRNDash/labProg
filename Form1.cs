using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        //Список кино

        List<Cinemas> cinemasList = new List<Cinemas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDesc.Text = "Нажмите кнопку \"Смотреть\", чтобы взять кино из списка";
            //очищаем список с очередью
            this.cinemasList.Clear();
            var rand = new Random();

            //рандомно заполняем его 10-ю элементами (Фильм, сериал или тв шоу)
            for (int i = 0; i < 10; i++)
            {
                // генерирую случайное число от 0 до 2
                switch (rand.Next() % 3) 
                {
                    case 0: // если 0, то фильм
                        this.cinemasList.Add(Film.Generate());
                        break;
                    case 1: // если 1 то сериал
                        this.cinemasList.Add(Serial.Generate());
                        break;
                    case 2: // если 2 то тв шоу
                        this.cinemasList.Add(TvShow.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }

            //Вызов метода обновления очереди
            ShowInfo();
        }

        // функция выводит информацию в очередь фильмов
        private void ShowInfo()
        {
            txtQueue.Text = "";
            //счётчик для нумерованного списка
            int counter = 0;

            // пройдемся по всему списку и сформируем список в очереди
            foreach (var cinema in this.cinemasList)
            {
                counter++;

                if (cinema is Film)
                {
                    txtQueue.Text += counter + ")  Фильм";
                }
                else if (cinema is Serial)
                {
                    txtQueue.Text += counter + ")  Сериал";
                }
                else if (cinema is TvShow)
                {
                    txtQueue.Text += counter + ")  Тв Шоу";
                }

                //стрелочка для обозначения следующего элемента в очереди
                if (counter == 1)
                {
                    txtQueue.Text += "     ---->\n";
                }
                else
                {
                    txtQueue.Text += "\n";
                }
            }
        }

        //Нажатие на кнопку "Смотреть"
        private void btnGet_Click(object sender, EventArgs e)
        {
            //Если список пуст
            if(cinemasList.Count == 0)
            {
                txtName.Text = "Больше фильмов нет :С";
                txtDesc.Text = "Нажмите кнопку \"Пересобрать\", чтобы обновить список";
                return;
            }

            //Взять информацию о первом элементе в списке и удалить его
            var cinema = this.cinemasList[0];
            cinemasList.RemoveAt(0);
            txtName.Text = cinema.GetName();
            txtDesc.Text = cinema.GetInfo();

            //Обновить очередь
            ShowInfo();
        }
    }
}
