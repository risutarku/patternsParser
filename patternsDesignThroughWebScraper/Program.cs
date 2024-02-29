using HtmlAgilityPack;

namespace patternsDesignThroughWebScraper
{
    internal class Program
    {
        public static void PrintNewsByRubric(List<News> newsList, string rubric)
        {
            News scienceNews = newsList.Find(news => news.Rubric == rubric);

            if (scienceNews != null)
            {
                foreach (News n in newsList)
                {
                    if(n.Rubric == rubric)
                    {
                        Console.WriteLine($"Новость по теме '{rubric}'");
                        Console.WriteLine(n.Title);
                        Console.WriteLine(n.Date);
                        Console.WriteLine("_-_-_-_-_-_-_-_-");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Новостей по теме '{rubric}' не найдено.");
            }
        }
        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
                "https://ngs.ru/text/?rubric=auto",
                "https://ngs.ru/text/?rubric=business",
                "https://ngs.ru/text/?rubric=spring",
                "https://ngs.ru/text/?rubric=gorod",
                "https://ngs.ru/text/?rubric=transport",
                "https://ngs.ru/text/?rubric=food",
                "https://ngs.ru/text/?rubric=animals",
                "https://ngs.ru/text/?rubric=sport"
            };
            List<News> allNews = new List<News>();
            foreach(string url in urls)
            {
                allNews = allNews.Union(WebScraper.scrap(url)).ToList();
            }
            //foreach(News n in allNews)
            //{
            //    Console.WriteLine(n.Rubric);
            //    Console.WriteLine(n.Title);
            //    Console.WriteLine(n.Date);
            //    Console.WriteLine("_-_-_-_-_-_-_-_-");
            //}

            PrintNewsByRubric(allNews, "Город");
            PrintNewsByRubric(allNews, "Наука");
            PrintNewsByRubric(allNews, "Спорт");
            PrintNewsByRubric(allNews, "Город");
            PrintNewsByRubric(allNews, "Город");

        }
    }
}