using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsDesignThroughWebScraper
{
    internal interface ISortable
    {
        List<News> Sort(List<News> news);
    }
}
