using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    //Родительский класс
    public class Cinemas
    {
        public static Random rand = new Random();
        public int rating = 0;

        public virtual String GetName()
        {
            var str = "Кино";
            return str;
        }

        public virtual String GetInfo()
        {
            var str = String.Format("Рейтинг: {0}", this.rating);
            return str;
        }
    }

    //Виды жанров
    public enum GenreType { comedy, drama, biography, trailer, horror };
    //Фильмы, дочерний класс
    public class Film : Cinemas
    {
        //жанр
        public GenreType genre = GenreType.comedy;
        //Длительность фильма
        public int duration = 0;

        // добавили статический метод генерации случайного фильма
        public static Film Generate()
        {
            return new Film
            {
                rating = rand.Next() % 10, // рейтинг от 0 до 10
                duration = rand.Next() % 150, //длительность фильма в минутах от 0 до 150
                genre = (GenreType)rand.Next(5), // жанр фильма (один из 5 видов)
            };
        }

        //Переопределим методы
        public override String GetName()
        {
            var str = "Фильм";
            return str;
        }

        public override String GetInfo()
        {
            var str = base.GetInfo();
            str += String.Format("\nДлительность: {0}", this.duration);
            str += "\nЖанр: ";
            if (this.genre == GenreType.biography)
            {
                str += "Биография";
            }
            else if (this.genre == GenreType.comedy)
            {
                str += "Комедия";
            }
            else if (this.genre == GenreType.drama)
            {
                str += "Драма";
            }
            else if (this.genre == GenreType.horror)
            {
                str += "Ужасы";
            }
            else
            {
                str += "Трейлер";
            }
            return str;
        }
    }

    //Сериалы, дочерний класс
    public class Serial : Cinemas
    {
        //кол-во серий
        public int episodeCount = 0; 
        //кол-во сезонов
        public int seasonCount = 0;

        // добавили статический метод генерации случайного тв шоу
        public static Serial Generate()
        {
            return new Serial
            {
                rating = rand.Next() % 10, // рейтинг от 0 до 10
                episodeCount = rand.Next() % 32, //кол-во серий от 0 до 32
                seasonCount = rand.Next() % 10, // кол-во сезонов от 0 до 10
            };
        }

        //Переопределим методы
        public override String GetName()
        {
            var str = "Сериал";
            return str;
        }
        public override String GetInfo()
        {
            var str = base.GetInfo();
            str += String.Format("\nСерий: {0}", this.episodeCount);
            str += String.Format("\nСезонов: {0}", this.seasonCount);
            return str;
        }
    }


    //Вид эфирного времени
    public enum AirtimeType { morning, afternoon, evening, night };

    //ТВ Шоу, дочерний класс
    public class TvShow : Cinemas
    {
        //Длительность шоу
        public int duration = 0;
        public AirtimeType airtime = AirtimeType.morning;

        // добавили статический метод генерации случайного тв шоу
        public static TvShow Generate()
        {
            return new TvShow
            {
                rating = rand.Next() % 10, // рейтинг от 0 до 10
                duration = rand.Next() % 40, //длительность шоу в минутах от 0 до 40
                airtime = (AirtimeType)rand.Next(4), // Эфирное время (один из 4 видов)
            };
        }


        //Переопределим методы
        public override String GetName()
        {
            var str = "Тв Шоу";
            return str;
        }

        public override String GetInfo()
        {
            var str = base.GetInfo();
            str += String.Format("\nДлительность: {0}", this.duration);
            str += "\nЭфирное время: ";
            if (this.airtime == AirtimeType.morning)
            {
                str += "Утренее";
            }
            else if (this.airtime == AirtimeType.afternoon)
            {
                str += "Дневное";
            }
            else if(this.airtime == AirtimeType.evening)
            {
                str += "Вечернее";
            }
            else 
            {
                str += "Ночное";
            }

            return str;
        }
    }
}