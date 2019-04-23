using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTTPRequest
{
    public class KuaiDi
    {
        public string msg
        {
            get;
            set;
        }

        public int status
        {
            get;
            set;
        }

        public int error_code
        {
            get;
            set;
        }
        public KuaiDiData data
        {
            get;
            set;
        }
    }
}
