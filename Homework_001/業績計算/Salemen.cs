using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 業績計算
{
    class Salemen
    {
        public string Saleman { get; set; }
        public int P { get; set; }
        public int PS { get; set; }
        public int ER { get; set; }
        public int RU { get; set; }
        public int LIC { get; set; }

        public int SUM
        {
            get { return P * 12 + PS * 16 + ER * 10 + RU * 14 + LIC * 15; }
        }
    }
}
