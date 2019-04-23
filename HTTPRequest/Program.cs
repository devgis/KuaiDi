using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;

namespace HTTPRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string orderNO = "";
            var rs = KuaiDiRequest.GetOrderInfo(CompanyEnum.中通快递, "719861459438");
            Console.WriteLine(rs.data.company.fullname);

            Console.Read();
        }
    }
}
