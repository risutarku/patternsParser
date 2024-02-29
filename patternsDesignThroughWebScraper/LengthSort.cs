using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsDesignThroughWebScraper
{
    internal class LengthSort : ISortable
    {
        public List<News> Sort(List<News> news)
        {

            for(int i = 0; i < news.Count - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < news.Count; j++)
                {
                    if (news[j].Title.Length < news[min].Title.Length)
                    {
                        min = j;
                    }
                }

                var tempVar = news[min];
                news[min] = news[i];
                news[i] = tempVar;
            }
            return news;
        }

    }
}
