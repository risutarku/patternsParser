using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace patternsDesignThroughWebScraper
{
    internal class WebScraper
    {
        public static void scrap()
        {
            string url = "https://ngs.ru/text/?rubric=spring";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var ulElements = htmlDocument.DocumentNode.Descendants("article")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("OPHIx")).ToList();

            int counter = 0;
            //foreach (var ulElement in ulElements)
            //{
            //    counter++;
            //    var topics = ulElement.Descendants("article").Where(a => !string.IsNullOrWhiteSpace(a.InnerText)).ToList();
            //    //var topics = ulElement.Descendants("article").Where(a => !string.IsNullOrWhiteSpace(a.InnerText)).ToList();
            //    if (topics.Count > 0)
            //    {
            //        Console.WriteLine(topics[0].InnerText.Trim());
            //    }
            //}
            foreach(var el in ulElements)
            {
                var rubrics = el.Descendants("div").Where(node => node.GetAttributeValue("class", "")
                .Contains("Zrw4X")).ToList();

                var head = el.Descendants("h2").Where(h2 => !string.IsNullOrWhiteSpace(h2.InnerText)).ToList();

                var time = el.Descendants("div").Where(node => node.GetAttributeValue("class", "")
                .Contains("XVQ6o")).ToList();

                if (rubrics.Count > 0)
                {
                    foreach(var rub in rubrics)
                    {
                        Console.WriteLine(rub.InnerText.Trim());
                    }
                    //Console.WriteLine(rubrics[0].InnerText.Trim());
                }
                if ( head.Count > 0)
                {
                    
                    Console.WriteLine(head[0].InnerText.Trim());
                }
                if (time.Count > 0)
                {
                    foreach (var t in time)
                    {
                        Console.WriteLine(t.InnerText.Trim());
                    }
                    //Console.WriteLine(rubrics[0].InnerText.Trim());
                }
                Console.WriteLine("____________");

            }
        }
    }
}
