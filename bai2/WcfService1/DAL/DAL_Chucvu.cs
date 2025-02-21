using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Chucvu : KetNoi
    {
        public List<Chucvu> Load_CV()
        {
            List<Chucvu> chucvus = new List<Chucvu>();
            DataTable dt = Load("select * from Chucvu");
            foreach(DataRow row in dt.Rows)
            {
                Chucvu chucvu = new Chucvu
                {
                    macv = row["Macv"].ToString(),
                    tencv = row["Tencv"].ToString(),
                    tientc = Convert.ToDouble(row["Tienphucap"].ToString())
                };
                chucvus.Add(chucvu);
            }
            return chucvus;
        }

        public void Insert(Chucvu chucvu)
        {
            string sql = "insert into Chucvu values ('"+ chucvu.macv +"', '"+ chucvu.tencv +"', "+ chucvu.tientc +")";
            ThucHien(sql);
        }

        public void Update(Chucvu chucvu)
        {
            string sql = "update Chucvu set Tencv = '"+ chucvu.tencv +"', Tienphucap = "+ chucvu.tientc +" where Macv = '"+ chucvu.macv +"'";
            ThucHien(sql);
        }

        public void Delete(Chucvu chucvu)
        {
            string sql = "delete from Chucvu where Macv = '"+ chucvu.macv +"'";
            ThucHien(sql);
        }
    }
}
