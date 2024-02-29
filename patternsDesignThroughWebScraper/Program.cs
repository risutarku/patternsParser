using HtmlAgilityPack;

namespace patternsDesignThroughWebScraper
{
    
    internal class Program
    {
        //public static List<News> GetNews(List<string> urls)
        //{
        //    List<News> allNews = new List<News>();
        //    foreach (string url in urls)
        //    {
        //        allNews = allNews.Union(WebScraper.Scrap(url)).ToList();
        //    }
        //    return allNews;
        //}
        public static List<News> GetNews(string url)
        {
            List<News> news =  WebScraper.Scrap(url).ToList();
            return news;
            
        }

        public static void PrintNews(List<News> newsList)
        {
            foreach(var el in newsList)
            {
                Console.WriteLine(el.Title);
                Console.WriteLine(el.Date);
            }
        }

        public static List<News> GenerateNews(Dictionary<string, string> rubricsAndUrls, string rubric)
        {
            if (rubricsAndUrls[rubric] != null)
            {
                List<News> news = GetNews(rubricsAndUrls[rubric]);
                return news;
            }
            else
            {
                Console.WriteLine("Такой темы нет");
                List<News> news = new List<News>();
                return news;
            }
        }
        static void Main(string[] args)
        {

            Dictionary<string, string> rubricsAndUrls = new Dictionary<string, string>()
            {
                {"Авто", "https://ngs.ru/text/?rubric=auto"},
                {"Бизнесс", "https://ngs.ru/text/?rubric=business"},
                {"Весна", "https://ngs.ru/text/?rubric=spring"},
                {"Город", "https://ngs.ru/text/?rubric=gorod"},
                {"Дороги и Транспорт", "https://ngs.ru/text/?rubric=transport"},
                {"Еда", "https://ngs.ru/text/?rubric=food"},
                {"Животные ", "https://ngs.ru/text/?rubric=animals"},
                {"Спорт",  "https://ngs.ru/text/?rubric=sport"}
            };

            List<News> news = GenerateNews(rubricsAndUrls, "Весна");
            PrintNews(news);
            Console.WriteLine("-----------------------------------------");

            NewsPresenter a = new NewsPresenter(news, new LengthSort());
            List<News> lengthSortedNews = a.Sort(news);
            PrintNews(lengthSortedNews);
            Console.WriteLine("-----------------------------------------");
            a.Sortable = new AlphabetSort();
            lengthSortedNews= a.Sort(news);
            PrintNews(lengthSortedNews);
        }
    }
    
}