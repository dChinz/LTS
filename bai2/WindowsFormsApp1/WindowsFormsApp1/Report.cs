using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void Report_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ServiceReference1.ReportData> data = client.Load_report().ToList();

            reportViewer1.LocalReport.ReportPath = @"D:\LapTrinhService\MH3TVSWCF\bai2\WindowsFormsApp1\WindowsFormsApp1\Report.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet", data);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
