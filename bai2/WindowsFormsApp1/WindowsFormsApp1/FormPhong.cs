using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void Phong_Load(object sender, EventArgs e)
        {
            List<ServiceReference1.Phong> dsPhong = client.Load_Ph().ToList();

            foreach(var sp in dsPhong)
            {
                ListViewItem item = new ListViewItem(sp.maph);
                item.SubItems.Add(sp.tenph);
                item.SubItems.Add(sp.sdt);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong
            {
                maph = textBoxMaph.Text,
                tenph = textBoxTenph.Text,
                sdt = textBoxSdt.Text,
            };
            client.Insert_ph(phong);
            var phongs = client.Load_Ph();
            foreach (var sp in phongs)
            {
                ListViewItem item = new ListViewItem(sp.maph);
                item.SubItems.Add(sp.tenph);
                item.SubItems.Add(sp.sdt);
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong
            {
                maph = textBoxMaph.Text,
                tenph = textBoxTenph.Text,
                sdt = textBoxSdt.Text,
            };
            client.Update_ph(phong);
            var phongs = client.Load_Ph();
            foreach (var sp in phongs)
            {
                ListViewItem item = new ListViewItem(sp.maph);
                item.SubItems.Add(sp.tenph);
                item.SubItems.Add(sp.sdt);
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong
            {
                maph = textBoxMaph.Text,
                tenph = textBoxTenph.Text,
                sdt = textBoxSdt.Text,
            };
            client.Delete_ph(phong);
            var phongs = client.Load_Ph();
            foreach (var sp in phongs)
            {
                ListViewItem item = new ListViewItem(sp.maph);
                item.SubItems.Add(sp.tenph);
                item.SubItems.Add(sp.sdt);
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var phongs = client.Load_Ph();

            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                textBoxMaph.Text = lv.SubItems[0].Text.Trim();
                textBoxTenph.Text = lv.SubItems[1].Text.Trim();
                textBoxSdt.Text = lv.SubItems[2].Text.Trim();
            }
        }
    }
}
