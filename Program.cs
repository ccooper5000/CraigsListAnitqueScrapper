using System;
using HtmlAgilityPack;
using System.Xml;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CraigsListAnitqueScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please PASTE your URL here. Then PRESS ENTER:");
            var inputFromUser = Console.ReadLine();
            Console.WriteLine("DataGrab process running....");
            Thread.Sleep(1000);

           var html = inputFromUser;

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(" //a[ normalize-space (@class) = 'result-title hdrlnk' ] ");
            HtmlNodeCollection h = htmlDoc.DocumentNode.SelectNodes(" //span[ normalize-space (@class) = 'result-price' ] ");


            foreach (HtmlNode node in nodes)
            {
                Console.WriteLine(node.InnerText.ToUpper() + "\r\n" + node.InnerText.ToUpper());
            }
            foreach (HtmlNode node in h)
            {
                Console.WriteLine(node.InnerText.ToUpper());
            }

            return;


        }
    }
}
