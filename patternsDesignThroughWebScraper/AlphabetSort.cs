using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsDesignThroughWebScraper
{
    internal class AlphabetSort : ISortable
    {
        public List<News> Sort(List<News> news)
        {
            news = news.OrderBy(n => n.Title).ToList();

            return news;
        }
    }
}
