using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace HTTPRequest
{
    public class MyWebRequest
    {
        public static string RequestInfo(string url,RequestInfo info)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method =info.Method;
            request.Accept = info.Accept;
            request.Referer = info.Referer;
            request.Headers.Add("content", info.Content);
            //request.Connection = "keep-alive";
            request.ContentType = info.ContentType;
            //request.Headers.Add(@"Accept:*/*");
            //request.Headers.Add("Accept-Encoding:gzip, deflate");
            request.Headers.Add(string.Format("Accept-Language:{0}",info.AcceptLanguage));
            //request.Headers.Add("Connection:keep-alive");
            request.Headers.Add(string.Format("Cookie:{0}",info.Cookie));
            //request.Headers.Add("Host:restapi.amap.com");
            //request.Headers.Add("Referer", "http://lbs.amap.com/api/javascript-api/example/amap-ui-poipicker/index");
            //request.Headers.Add("User-Agent:Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.109 Safari/537.36");
            request.UserAgent = info.UserAgent;
            request.Host = info.Host;
            return ReadStringResponse(request.GetResponse());
        }

        private static string ReadStringResponse(WebResponse response)
        {
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8); //Encoding.GetEncoding("GB2312")
            String retXml = sr.ReadToEnd();
            sr.Close();
            return retXml;
        }
    }
}
