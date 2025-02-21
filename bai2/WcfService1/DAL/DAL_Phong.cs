using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Phong : KetNoi
    {
        public List<Phong> Load_ph()
        {
            List<Phong> dsPh = new List<Phong>();
            DataTable dt = Load("select * from Phong");
            foreach (DataRow row in dt.Rows)
            {
                Phong phong = new Phong
                {
                    maph = row["MaPhong"].ToString(),
                    tenph = row["TenPhong"].ToString(),
                    sdt = row["DienThoai"].ToString()
                };
                dsPh.Add(phong);
            }
            return dsPh;
        }

        public void Insert(Phong phong)
        {
            string sql = "insert into Phong values ('" + phong.maph + "', '" + phong.tenph + "', '" + phong.sdt + "')";
            ThucHien(sql);
        }

        public void Update(Phong phong)
        {
            string sql = "update Phong set Tenphong = '"+ phong.tenph +"', Dienthoai = '"+ phong.sdt +"' where Maphong = '"+ phong.maph +"'";
            ThucHien(sql);
        }

        public void Delete(Phong phong)
        {
            string sql = "delete from Phong where Tenphong = '"+ phong.tenph +"'";
            ThucHien(sql);
        }
    }
}
