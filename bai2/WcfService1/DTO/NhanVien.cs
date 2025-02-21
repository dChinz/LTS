using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string manv {  get; set; }
        public string tennv { get; set; }
        public DateTime ngaysinh { get; set; }
        public string maph { get; set; }
        public string macv { get; set; }
        public double luong {  get; set; }
        public NhanVien () { }
        
        public NhanVien(string manv, string tennv, DateTime ngaysinh, string maph, string macv, double luong)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.maph = maph;
            this.macv = macv;
            this.luong = luong;
        }
    }
}
