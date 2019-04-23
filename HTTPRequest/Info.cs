using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTTPRequest
{
    public class Info
    {
        public int status
        {
            get;
            set;
        }
        public string com
        {
            get;
            set;
        }
        public int state
        {
            get;
            set;
        }

        public List<ContextItem> context
        {
            get;
            set;
        }

        public string _source_com
        {
            get;
            set;
        }
        public string _support_from
        {
            get;
            set;
        }
    }
}
