using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using static System.Net.WebRequestMethods;

namespace patternsDesignThroughWebScraper
{
    internal class WebScraper
    {
        public static List<News> scrap(string url)
        {
            List<News> newsList = new List<News>();
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var ulElements = htmlDocument.DocumentNode.Descendants("article")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("OPHIx")).ToList();
            int counter = 0;
            foreach(var el in ulElements)
            {
                var rubrics = el.Descendants("div").Where(node => node.GetAttributeValue("class", "")
                .Contains("Zrw4X")).ToList();

                var title = el.Descendants("h2").Where(h2 => !string.IsNullOrWhiteSpace(h2.InnerText)).ToList();

                var time = el.Descendants("div").Where(node => node.GetAttributeValue("class", "")
                .Contains("XVQ6o")).ToList();
                counter++;
                newsList.Add(new News(rubrics[0].InnerText.Trim(), title[0].InnerText.Trim(), time[0].InnerText.Split(',')[0]));

                if (counter > 20)
                    break;
            }

            return newsList;
        }
    }
}
