using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPhong_Click(object sender, EventArgs e)
        {
            FormPhong f = new FormPhong();
            f.Show();
        }

        private void buttonChucvu_Click(object sender, EventArgs e)
        {
            FormChucvu f = new FormChucvu();
            f.Show();
        }

        private void buttonNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanvien f = new FormNhanvien();
            f.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            Report f = new Report();
            f.Show();
        }
    }
}
