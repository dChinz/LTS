using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chucvu
    {
        public string macv { get; set; }
        public string tencv { get; set; }
        public double tientc { get; set; }

        public Chucvu() { }

        public Chucvu(string macv, string tencv, double tientc)
        {
            this.macv = macv;
            this.tencv = tencv;
            this.tientc = tientc;
        }
    }
}
