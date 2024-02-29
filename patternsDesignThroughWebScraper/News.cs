using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsDesignThroughWebScraper
{
    internal class News
    {

        public string Rubric { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public News(string rubric, string title, String date)
        {
            Rubric = rubric;
            Title = title;
            Date = date;
        }
        #region
        //class Program
        //{
        //    static void Main()
        //    {
        //        // Пример использования
        //        List<News> newsList = new List<News>();

        //        // Добавление новостей
        //        newsList.Add(new News("Политика", "Новый закон принят в парламенте", DateTime.Parse("2024-02-29")));
        //        newsList.Add(new News("Наука", "Открытие новой планеты в солнечной системе", DateTime.Parse("2024-03-01")));
        //        newsList.Add(new News("Спорт", "Футбольная команда выиграла чемпионат", DateTime.Parse("2024-03-02")));

        //        // Получение новости по теме
        //        string desiredTopic = "Наука";
        //        News scienceNews = newsList.Find(news => news.Topic == desiredTopic);

        //        if (scienceNews != null)
        //        {
        //            Console.WriteLine($"Новость по теме '{desiredTopic}': {scienceNews.Title} ({scienceNews.Date})");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Новостей по теме '{desiredTopic}' не найдено.");
        //        }
        //    }
        //}
        #endregion

    }
}
