using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTTPRequest
{
    public class Company
    {
        public string url
        {
            get;
            set;
        }
         public string fullname
        {
            get;
            set;
        }
         public string shortname
        {
            get;
            set;
        }

        public CompanyICO icon
        {
            get;
            set;
        }
        public CompanyWebsite website
        {
            get;
            set;
        }
        public string tel
        {
            get;
            set;
        }

        public List<AuxiliaryItem> auxiliary
        {
            get;
            set;
        }
        public Timecost timecost
        {
            get;
            set;
        }

        public Onlineorder onlineorder
        {
            get;
            set;
        }
    }

}
