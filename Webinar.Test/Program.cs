using System;
using System.Threading.Tasks;

namespace RssSata.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
              //  await FeedItemsParse.ParseAsync("http://lenta.ru/rss/");
                Console.WriteLine("Hello World!");
            }
            catch (Exception ee)
            {

                Console.WriteLine(ee.Message);
                Console.WriteLine(ee.StackTrace);

            }
            
        }
    }
}
