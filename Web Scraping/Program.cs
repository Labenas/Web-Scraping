using HtmlAgilityPack;
using System;

namespace Web_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = "https://www.cvonline.lt/darbo-skelbimai/informacines-technologijos/q-.net/q-.net/vilniaus?page=1";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            foreach (var nNode in htmlDoc.DocumentNode.SelectNodes("//h2"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {   
                    
                    Console.WriteLine(nNode.InnerText);
                }
            }
        }
    }
}
