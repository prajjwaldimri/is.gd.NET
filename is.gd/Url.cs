using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace @is.gd
{
    public class Url
    {
        /// <summary>
        /// https://is.gd/apishorteningreference.php
        /// </summary>
        /// <param name="url">The url parameter is the address that you want to shorten. You do not need to encode this as it is automatically done!</param>
        /// <param name="shorturl">You can specify the shorturl parameter if you'd like to pick a shortened URL instead of having is.gd randomly generate one.</param>
        /// <param name="logstats">Adding the parameter logstats=1 turns on logging of detailed statistics when the shortened URL you create is accessed</param>
        /// <param name="v">Set this to true if you want to use v.gd instead of is.gd</param>
        /// <returns>A ShortenedUrl Object containing either the url or error message</returns>
        public static async Task<string> GetShortenedUrl(string url, string shorturl = "", bool logstats = false, bool v = false)
        {
            var client = new HttpClient();
            var domain = v ? "v.gd" : "is.gd";
            string uri;
            if (logstats)
            {
                uri = Uri.EscapeUriString($"https://{domain}/create.php?format=simple&url={url}&logstats=1");
            }
            else
            {
                uri = Uri.EscapeUriString($"https://{domain}/create.php?format=simple&url={url}");
            }

            var responseMessage = await client.GetAsync(uri);
            var response = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(response);
            }
            return response;
        }

        /// <summary>
        /// https://is.gd/apilookupreference.php
        /// </summary>
        /// <param name="shorturl">The shorturl parameter is the shortened is.gd/v.gd URL that you want to look up</param>
        /// <param name="v">Set this to true if you want to use v.gd instead of is.gd</param>
        /// <returns></returns>
        public static async Task<string> LookupShortenedUrl(string shorturl, bool v = false)
        {
            var client = new HttpClient();
            var domain = v ? "v.gd" : "is.gd";
            var uri = Uri.EscapeUriString($"https://{domain}/forward.php?format=simple&shorturl={shorturl}");
            var responseMessage = await client.GetAsync(uri);
            var response = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(response);
            }
            return response;
        }
    }
}
