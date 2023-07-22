using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dell_fans_controller
{
    internal class info
    {
        
        public int id;
        public string deviceName;
        public string p1;
        public string p2;
        public string p3;
        public string p4;
        public string p5;
        public string p6;
        public string p7;
        public string p8;
        public string p9;

        public info()
        {
        }

        public info(int id, string deviceName, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            this.id = id;
            this.deviceName = deviceName;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
            this.p8 = p8;
            this.p9 = p9;
        }
    }
}
