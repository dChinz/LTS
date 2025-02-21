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
    public partial class FormChucvu : Form
    {
        public FormChucvu()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void Chucvu_Load(object sender, EventArgs e)
        {
            List<ServiceReference1.Chucvu> chucvus = client.Load_cv().ToList();

            foreach(var sp in chucvus)
            {
                ListViewItem lv = new ListViewItem(sp.macv);
                lv.SubItems.Add(sp.tencv);
                lv.SubItems.Add(sp.tientc.ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chucvu chucvu = new Chucvu
            {
                macv = textBoxMacv.Text,
                tencv = textBoxTencv.Text,
                tientc = Convert.ToDouble(textBoxTtc.Text),
            };
            client.Insert_cv(chucvu);
            var chucvus = client.Load_cv();
            foreach(var sp in chucvus)
            {
                ListViewItem lv = new ListViewItem(sp.macv);
                lv.SubItems.Add(sp.tencv);
                lv.SubItems.Add(sp.tientc.ToString());
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chucvu chucvu = new Chucvu
            {
                macv = textBoxMacv.Text,
                tencv = textBoxTencv.Text,
                tientc = Convert.ToDouble(textBoxTtc.Text),
            };
            client.Update_cv(chucvu);
            var chucvus = client.Load_cv();
            foreach (var sp in chucvus)
            {
                ListViewItem lv = new ListViewItem(sp.macv);
                lv.SubItems.Add(sp.tencv);
                lv.SubItems.Add(sp.tientc.ToString());
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chucvu chucvu = new Chucvu
            {
                macv = textBoxMacv.Text,
                tencv = textBoxTencv.Text,
                tientc = Convert.ToDouble(textBoxTtc.Text),
            };
            client.Delete_cv(chucvu);
            var chucvus = client.Load_cv();
            foreach (var sp in chucvus)
            {
                ListViewItem lv = new ListViewItem(sp.macv);
                lv.SubItems.Add(sp.tencv);
                lv.SubItems.Add(sp.tientc.ToString());
                listView1.Items.Add(lv);
            }
            listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chucvus = client.Load_cv();

            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                textBoxMacv.Text = lv.SubItems[0].Text.Trim();
                textBoxTencv.Text = lv.SubItems[1].Text.Trim();
                textBoxTtc.Text = lv.SubItems[2].Text.Trim();
            }
        }
    }
}
