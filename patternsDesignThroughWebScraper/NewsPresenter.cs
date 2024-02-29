using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsDesignThroughWebScraper
{
    internal class NewsPresenter
    {
        public List<News> News;
        public NewsPresenter(List<News> news, ISortable sort)
        {
            News = news;
            Sortable = sort;
        }
        public ISortable Sortable { private get; set; }
        public List<News> Sort(List<News> news)
        {
            News = Sortable.Sort(news);
            return News;
        }
    }
}
