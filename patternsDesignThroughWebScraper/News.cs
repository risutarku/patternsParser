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



    }
}
