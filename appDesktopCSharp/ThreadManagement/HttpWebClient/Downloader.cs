using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpWebClient
{
    internal class Downloader
    {
        public async static Task<HttpResponseMessage> Download(Uri uri)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(uri);
            return response;
        }

        public async static void Download(Object? uri) 
        {
            HttpResponseMessage response = await Download((Uri)uri);
            string json = await response.Content.ReadAsStringAsync();
        }
    }
}
