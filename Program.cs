using System;
using HtmlAgilityPack;

namespace CraigsListAnitqueScrapper
{
    class Program
    {
        public static void Main(string[] args)
        {
            var html = "https://sanantonio.craigslist.org/search/ata";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html); 
            var nodes = htmlDoc.DocumentNode.SelectNodes("//li[(@class= 'result-row') ]");
            var rootNode = htmlDoc.DocumentNode;

            foreach (var node in nodes)
            {
                Console.WriteLine(node.InnerText);
            }
        if (nodes == null)
            {
                Console.WriteLine("No items found.");
            }

        }
    }
}
