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
    public partial class FormNhanvien : Form
    {
        public FormNhanvien()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void FormNhanvien_Load(object sender, EventArgs e)
        {
            List<ServiceReference1.NhanVien> nhanViens = client.Load_nv().ToList();
            listView1.Items.Clear();

            foreach(var sp in nhanViens)
            {
                ListViewItem lv = new ListViewItem(sp.manv);
                lv.SubItems.Add(sp.tennv);
                lv.SubItems.Add(sp.ngaysinh.ToString());
                lv.SubItems.Add(sp.maph);
                lv.SubItems.Add(sp.macv);
                lv.SubItems.Add(sp.luong.ToString());
                listView1.Items.Add(lv);
            }

            List<ServiceReference1.Phong> phongs = client.Load_Ph().ToList();
            comboBoxMaph.DataSource = phongs;
            comboBoxMaph.DisplayMember = "tenph";
            comboBoxMaph.ValueMember = "maph";
            comboBoxMaph.SelectedIndex = -1;

            List<ServiceReference1.Chucvu> chucvus = client.Load_cv().ToList();
            comboBoxMacv.DataSource = chucvus;
            comboBoxMacv.DisplayMember = "tencv";
            comboBoxMacv.ValueMember = "macv";
            comboBoxMacv.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien
            {
                manv = textBoxManv.Text,
                tennv = textBoxTennv.Text,
                ngaysinh = Convert.ToDateTime(textBoxNgaysinh.Text),
                maph = comboBoxMaph.SelectedValue.ToString(),
                macv = comboBoxMacv.SelectedValue.ToString(),
                luong = Convert.ToDouble(textBoxLuong.Text),
            };
            client.Insert(nhanVien);
            var nhanviens = client.Load_nv().ToList();
            foreach( var sp in nhanviens)
            {
                ListViewItem lv = new ListViewItem(sp.manv);
                lv.SubItems.Add(sp.tennv);
                lv.SubItems.Add(sp.ngaysinh.ToString());
                lv.SubItems.Add(sp.maph);
                lv.SubItems.Add(sp.macv);
                lv.SubItems.Add(sp.luong.ToString());
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien
            {
                manv = textBoxManv.Text,
                tennv = textBoxTennv.Text,
                ngaysinh = Convert.ToDateTime(textBoxNgaysinh.Text),
                maph = comboBoxMaph.SelectedValue.ToString(),
                macv = comboBoxMacv.SelectedValue.ToString(),
                luong = Convert.ToDouble(textBoxLuong.Text),
            };
            client.Update(nhanVien);
            var nhanviens = client.Load_nv().ToList();
            foreach (var sp in nhanviens)
            {
                ListViewItem lv = new ListViewItem(sp.manv);
                lv.SubItems.Add(sp.tennv);
                lv.SubItems.Add(sp.ngaysinh.ToString());
                lv.SubItems.Add(sp.maph);
                lv.SubItems.Add(sp.macv);
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien
            {
                manv = textBoxManv.Text,
                tennv = textBoxTennv.Text,
                ngaysinh = Convert.ToDateTime(textBoxNgaysinh.Text),
                maph = comboBoxMaph.SelectedValue.ToString(),
                macv = comboBoxMacv.SelectedValue.ToString(),
                luong = Convert.ToDouble(textBoxLuong.Text),
            };
            client.Delete(nhanVien);
            var nhanviens = client.Load_nv().ToList();
            foreach (var sp in nhanviens)
            {
                ListViewItem lv = new ListViewItem(sp.manv);
                lv.SubItems.Add(sp.tennv);
                lv.SubItems.Add(sp.ngaysinh.ToString());
                lv.SubItems.Add(sp.maph);
                lv.SubItems.Add(sp.macv);
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ServiceReference1.NhanVien> nhanViens = client.Load_nv().ToList(); 

            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                textBoxManv.Text = lv.SubItems[0].Text.Trim();
                textBoxTennv.Text = lv.SubItems[1].Text.Trim();
                textBoxNgaysinh.Text = lv.SubItems[2].Text.Trim();
                comboBoxMaph.Text = lv.SubItems[3].Text.Trim();
                comboBoxMacv.Text = lv.SubItems[4].Text.Trim();
                textBoxLuong.Text = lv.SubItems[5].Text.Trim();
            }
        }
    }
}
