using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Auto_Mail_Activation
{
    class TwitterHttpHandler
    {
        private CookieContainer cookies = new CookieContainer();
        private HttpClientHandler handler = new HttpClientHandler();
        private HttpClient client;




        public TwitterHttpHandler()
        {

            cookies = new CookieContainer();
            handler = new HttpClientHandler();
            handler.CookieContainer = cookies;
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0)");
            client.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.9,ar;q=0.8,mt;q=0.7");
            client.DefaultRequestHeaders.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");





        }


        public async void loginAsync()
        {
            var PrepareThePage = await client.GetStringAsync("https://twitter.com/login");





        }

































    }
}
