using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Util
{
    public static class Mining
    {

        public static List<string> GetNDgtNbr(string content, string N)
        {
            Regex regexLink = new Regex(@"\d{" + N + "}");
            List<string> newLinks = new List<string>();

            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }
        public static List<string> GetTdTags(string content)
        {
            Regex regexLink = new Regex("<td\\s*.*>\\s*.*<\\/td>");
            List<string> newLinks = new List<string>();

            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }
        public static List<string> GetCapital(string content)
        {
            Regex regexLink = new Regex("([A-Z])\\w+");
            List<string> newLinks = new List<string>();

            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }

        public static string GetDomainFromTxtBox(string txtBox)
        {
            string[] strArrUrlSlash = txtBox.Split('/');

            StringBuilder sb = new StringBuilder();

            for (int i = 2; i < strArrUrlSlash.Length; i++)
            {
                sb.Append(strArrUrlSlash[i]);
            }
            var res = sb.ToString();

            return sb.ToString();
        }
        public static List<string> GetNewLinks(string content)
        {
            Regex regexLink = new Regex("(?<=<a\\s*?href=(?:'|\"))[^'\"]*?(?=(?:'|\"))");

            List<string> newLinks = new List<string>();

            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }

        public static List<string> GetMp4(string content)
        {

            Regex regexLink = new Regex(@"https?.*?\.mp4");

            List<string> newLinks = new List<string>();

            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }
        public static string GetHtmlURL(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;

            string result;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        result = content.ReadAsStringAsync().Result;
                    }
                }
            }
            return result;
        }
        public static string GetStrHtml(string path)
        {
            var reader = new StreamReader(path, Encoding.UTF8);
            return reader.ReadToEnd();
        }

    }
}
