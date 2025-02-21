using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Nhanvien : KetNoi
    {
        public List<NhanVien> Load_NV()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            DataTable dt = Load("select * from Nhanvien");
            foreach (DataRow dr in dt.Rows)
            {
                NhanVien nhanVien = new NhanVien
                {
                    manv = dr["Manv"].ToString(),
                    tennv = dr["Hoten"].ToString(),
                    ngaysinh = Convert.ToDateTime(dr["Ngaysinh"].ToString()),
                    maph = dr["Maph"].ToString(),
                    macv = dr["Macv"].ToString(),
                    luong = Convert.ToDouble(dr["Luong"].ToString())
                };
                nhanViens.Add(nhanVien);
            }
            return nhanViens;
        }

        public void Insert(NhanVien nhanVien)
        {
            string sql = "insert into Nhanvien values ('"+ nhanVien.manv +"', '"+ nhanVien.tennv +"', '"+ nhanVien.ngaysinh +"', '"+ nhanVien.maph +"', '"+ nhanVien.macv +"', "+ nhanVien.luong +")";
            ThucHien(sql);
        }

        public void Update(NhanVien nhanVien)
        {
            string sql = "update Nhanvien set Hoten = '"+ nhanVien.tennv +"', Ngaysinh = '"+ nhanVien.ngaysinh +"', Maph = '"+ nhanVien.maph +"', Macv = '"+ nhanVien.macv +"', Luong = "+ nhanVien.luong +" where Manv = '"+ nhanVien.manv +"'";
            ThucHien(sql);
        }

        public void Delete(NhanVien nhanVien)
        {
            string sql = "delete fron Nhanvien where Manv = '"+ nhanVien.manv +"'";
            ThucHien(sql);
        }

        public List<ReportData> data()
        {
            List<ReportData> reportDatas = new List<ReportData>();

            string sql = @"select Phong.Tenphong, Chucvu.Tencv, Nhanvien.Manv, Nhanvien.Hoten, Nhanvien.Luong
                            from Nhanvien
                            inner join Phong on Nhanvien.Maph = Phong.Maphong
                            inner join Chucvu on Nhanvien.Macv = Chucvu.Macv
                            order by Phong.Tenphong";
            DataTable dt = new DataTable(); 
            using(SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLNhansu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    reportDatas.Add(new ReportData
                    {
                        tenph = dr["Tenphong"].ToString(),
                        tencv = dr["Tencv"].ToString(),
                        manv = dr["Manv"].ToString(),
                        hoten = dr["Hoten"].ToString(),
                        luong = Convert.ToDouble(dr["Luong"].ToString()),
                    });
                }
            }
            return reportDatas;
        }
    }
}
