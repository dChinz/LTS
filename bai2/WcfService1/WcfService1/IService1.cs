using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Phong> Load_Ph();

        [OperationContract]
        void Insert_ph(Phong phong);
        [OperationContract]
        void Update_ph(Phong phong);
        [OperationContract]
        void Delete_ph(Phong phong);
        [OperationContract]
        List<Chucvu> Load_cv();
        [OperationContract]
        void Insert_cv(Chucvu chucvu);
        [OperationContract]
        void Update_cv(Chucvu chucvu);
        [OperationContract]
        void Delete_cv(Chucvu chucvu);
        [OperationContract]
        List<NhanVien> Load_nv();
        [OperationContract]
        void Insert(NhanVien chu);
        [OperationContract]
        void Update(NhanVien chu);
        [OperationContract]
        void Delete(NhanVien chu);

        [OperationContract]
        List<ReportData> Load_report();
    }
}
