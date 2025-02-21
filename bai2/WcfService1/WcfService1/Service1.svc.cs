using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;
using DTO;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private DAL_Phong dal_ph = new DAL_Phong();
        public List<Phong> Load_Ph()
        {
            return dal_ph.Load_ph();
        }

        public void Insert_ph(Phong ph)
        {
            dal_ph.Insert(ph);
        }

        public void Update_ph(Phong ph)
        {
            dal_ph.Update(ph);
        }

        public void Delete_ph(Phong ph)
        {
            dal_ph.Delete(ph);
        }

        private DAL_Chucvu cv = new DAL_Chucvu();

        public List<Chucvu> Load_cv()
        {
            return cv.Load_CV();
        }

        public void Insert_cv(Chucvu chu)
        {
            cv.Insert(chu);
        }

        public void Update_cv(Chucvu chu)
        {
            cv.Update(chu);
        }

        public void Delete_cv(Chucvu chu)
        {
            cv.Delete(chu);
        }

        private DAL_Nhanvien nv = new DAL_Nhanvien();

        public List<NhanVien> Load_nv()
        {
            return nv.Load_NV();
        }

        public void Insert(NhanVien nha)
        {
            nv.Insert(nha);
        }

        public void Update(NhanVien nha)
        {
            nv.Update(nha);
        }

        public void Delete(NhanVien nha)
        {
            nv.Delete(nha);
        }

        public List<ReportData> Load_report()
        {
            return nv.data();
        }
    }
}
