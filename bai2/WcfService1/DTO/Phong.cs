using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        public string maph { get; set; }
        public string tenph { get; set; }
        public string sdt { get; set; }

        public Phong() { }
        public Phong(string maph, string tenph, string sdt)
        {
            this.maph = maph;
            this.tenph = tenph;
            this.sdt = sdt;
        }
    }
}
