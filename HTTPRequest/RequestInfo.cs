using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTTPRequest
{
    public class RequestInfo
    {
        public string Method = "GET";
        public string Accept = "*/*";
        public string Referer = "http://lbs.amap.com/api/javascript-api/example/amap-ui-poipicker/index";
        public string Content="text/html; charset=gb2312";
        public string ContentType = "application/x-www-form-urlencoded";
        public string AcceptLanguage="zh-CN,zh;q=0.8";
        public string Cookie="guid=a811-e886-1dcc-e863; UM_distinctid=15d971401c66d-08ba3b9679694f-474b0921-1fa400-15d971401c742; passport_login=MzM5NzY0MzcsZGV2Z2lzLGoza2wwejM1ZWw3aW91ZTY4a25tODQ1MHh6OTVuaWppLDE1MDE0Nzg3NDEsWXpVMlptRTRNbUppWlRJeFptUXhPVFUzWW1Vd1pUazNZbVkzWldZellqYz0%3D; dev_help=Wu9c64otg7AmTW56C%2BTFXTliNjBjZDRlODQ1YzQxZGJmMDIyM2I3NGJiYTIzNDk2YWNiYjFkZmZmNzhjNGYzZmFhY2M0NjczY2RjNzgxYjW0OTS6zg8W8tWchCDVZgS0w2jDcUKmFj%2BcNsvo16IRuPycGsxeefgb7oj4NJjWit1UYQ9xDC2OaM%2BA8g%2BfCa2OFs5COgVyqiRCKSdToZIlBA%3D%3D; key=608d75903d29ad471362f8c58c550daf";
        public string Host="restapi.amap.com";
        public string UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.109 Safari/537.36";
    }
}
