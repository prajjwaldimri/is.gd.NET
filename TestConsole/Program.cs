using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using @is.gd;

namespace TestConsole
{
    class Program
    {
        private static void Main(string[] args)
        {
           var shortenedUrl = Url.GetShortenedUrl(
                "www.example.com", v:true).Result;
            Console.WriteLine("Shortened Url: " + shortenedUrl);
            var fullUrl = Url.LookupShortenedUrl(shortenedUrl, true).Result;
            Console.WriteLine("Full Url: " + fullUrl);
            Console.ReadLine();
        }
    }
}
