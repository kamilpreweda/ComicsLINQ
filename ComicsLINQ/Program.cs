using System.Collections.Generic;
using System.Linq;

namespace ComicsLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> mostExpensiveComicDescriptions =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select $"{comic} jest wart {Comic.Prices[comic.Issue]:c}";

           
        }
    }
}