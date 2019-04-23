using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;
using System.Globalization;
using Newtonsoft.Json;

namespace HTTPRequest
{
    public class KuaiDiRequest
    {
        static RequestInfo info = null;
        static KuaiDiRequest()
        {
            info = new RequestInfo();
//Accept:*/*
//Accept-Encoding:gzip, deflate, br
//Accept-Language:zh-CN,zh;q=0.8
//Connection:keep-alive
//Cookie:PSTM=1502175879; BAIDUID=45320EBF0C046A0022104A54B974403C:FG=1; BIDUPSID=6EABDE8A0DD281BB906554EE40333DC8; BDUSS=RNM1hGSlZxam9uTXU0ZGUxTll6VGZJNC1TakZ-QVVXZ25uUkFwUGRSOGNGckpaSVFBQUFBJCQAAAAAAAAAAAEAAABlhqMcsaa8ptausaYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAByJilkciYpZRl; MCITY=-233%3A; BDRCVFR[feWj1Vr5u3D]=I67x6TjHwwYf0; PSINO=1; H_PS_PSSID=1429_21099_20929; BDORZ=B490B5EBF6F3CD402E515D22BCDA1598
//Host:sp0.baidu.com
//Referer:https://www.baidu.com/s?wd=%E4%B8%AD%E9%80%9A&rsv_spt=1&rsv_iqid=0xc03f3559000011b7&issp=1&f=8&rsv_bp=0&rsv_idx=2&ie=utf-8&tn=baiduhome_pg&rsv_enter=1&rsv_sug3=11&rsv_sug1=6&rsv_sug7=100&rsv_sug2=0&inputT=2537&rsv_sug4=5030&rsv_sug=2
//User-Agent:Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.90 Safari/537.36

            info.Method = "GET";
            info.Accept = "*/*";
            info.Referer = "https://www.baidu.com/s?wd=%E4%B8%AD%E9%80%9A&rsv_spt=1&rsv_iqid=0xc03f3559000011b7&issp=1&f=8&rsv_bp=0&rsv_idx=2&ie=utf-8&tn=baiduhome_pg&rsv_enter=1&rsv_sug3=11&rsv_sug1=6&rsv_sug7=100&rsv_sug2=0&inputT=2537&rsv_sug4=5030&rsv_sug=2";
            info.Content="text/html; charset=gb2312";
            info.ContentType = "application/x-www-form-urlencoded";
            info.AcceptLanguage="zh-CN,zh;q=0.8";
            info.Cookie="PSTM=1502175879; BAIDUID=45320EBF0C046A0022104A54B974403C:FG=1; BIDUPSID=6EABDE8A0DD281BB906554EE40333DC8; BDUSS=RNM1hGSlZxam9uTXU0ZGUxTll6VGZJNC1TakZ-QVVXZ25uUkFwUGRSOGNGckpaSVFBQUFBJCQAAAAAAAAAAAEAAABlhqMcsaa8ptausaYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAByJilkciYpZRl; MCITY=-233%3A; BDRCVFR[feWj1Vr5u3D]=I67x6TjHwwYf0; PSINO=1; H_PS_PSSID=1429_21099_20929; BDORZ=B490B5EBF6F3CD402E515D22BCDA1598";
            info.Host = "sp0.baidu.com";
            info.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.109 Safari/537.36";
        }
        public static string SearchOrder(CompanyEnum company, string oraderNO,bool decode=false)
        {
            string com = string.Empty;
            switch (company)
            {
                case CompanyEnum.EMS:
                    com = "ems";
                    break;
                case CompanyEnum.顺丰快递:
                    com = "shunfeng";
                    break;
                case CompanyEnum.圆通快递:
                    com = "yuantong";
                    break;
                case CompanyEnum.中通快递:
                    com = "zhongtong";
                    break;
                case CompanyEnum.百世快递:
                    com = "huitongkuaidi";
                    break;
                case CompanyEnum.申通快递:
                    com = "shentong";
                    break;
                case CompanyEnum.韵达快递:
                    com = "yunda";
                    break;
                case CompanyEnum.天天快递:
                    com = "tiantian";
                    break;
                case CompanyEnum.宅急送:
                    com = "zhaijisong";
                    break;
                    case CompanyEnum.全峰快递:
                    com = "quanfengkuaidi";
                    break;
                case CompanyEnum.德邦物流:
                    com = "debangwuliu";
                    break;
                case CompanyEnum.邮政小包:
                    com = "youzhengguonei";
                    break;
            }
            ////string typename = HttpUtility.UrlDecode(typeWord, Encoding.UTF8);
            //string url = string.Format("https://sp0.baidu.com/9_Q4sjW91Qh3otqbppnN2DJv/pae/channel/data/asyncqury?cb=jQuery1102009268465627365785_1502438516246&appid=4001&com={0}&nu={1}&vcode=&token=&_=1502438516257"
            //    ,com, oraderNO);
            //string srs = MyWebRequest.RequestInfo(url, info);
            //string arrtemp = srs.Split('(')[0];
            //srs = srs.Replace(arrtemp, "");
            //srs = srs.TrimStart('(');
            //srs = srs.TrimEnd(')');
            //if (decode)
            //{
            //    return Decode(srs);//解码
            //}
            //else
            //{
            //    return srs; //不解码
            //}
            return SearchOrder(com, oraderNO, decode);
        }

        public static string SearchOrder(string companycode, string oraderNO, bool decode = false)
        {
            //string typename = HttpUtility.UrlDecode(typeWord, Encoding.UTF8);
            string url = string.Format("https://sp0.baidu.com/9_Q4sjW91Qh3otqbppnN2DJv/pae/channel/data/asyncqury?cb=jQuery1102009268465627365785_1502438516246&appid=4001&com={0}&nu={1}&vcode=&token=&_=1502438516257"
                , companycode, oraderNO);
            string srs = MyWebRequest.RequestInfo(url, info);
            string arrtemp = srs.Split('(')[0];
            srs = srs.Replace(arrtemp, "");
            srs = srs.TrimStart('(');
            srs = srs.TrimEnd(')');
            if (decode)
            {
                return Decode(srs);//解码
            }
            else
            {
                return srs; //不解码
            }
        }

        public static KuaiDi GetOrderInfo(CompanyEnum company, string oraderNO, bool decode = false)
        {
            var rsstr = SearchOrder(company, oraderNO, decode);
            return JsonConvert.DeserializeObject<KuaiDi>(rsstr);
        }


        static Regex reUnicode = new Regex(@"\\u([0-9a-fA-F]{4})", RegexOptions.Compiled);

        public static string Decode(string s)
        {
            return reUnicode.Replace(s, m =>
            {
                short c;
                if (short.TryParse(m.Groups[1].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out c))
                {
                    return "" + (char)c;
                }
                return m.Value;
            });
        }  

       
    }
}
