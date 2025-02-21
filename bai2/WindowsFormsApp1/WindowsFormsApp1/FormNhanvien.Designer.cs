namespace WindowsFormsApp1
{
    partial class FormNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tennv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNgaysinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxManv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMaph = new System.Windows.Forms.ComboBox();
            this.comboBoxMacv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Maph = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Macv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Luong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Manv,
            this.Tennv,
            this.Ngaysinh,
            this.Maph,
            this.Macv,
            this.Luong});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(79, 355);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1086, 263);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Manv
            // 
            this.Manv.Text = "Mã NV";
            this.Manv.Width = 166;
            // 
            // Tennv
            // 
            this.Tennv.Text = "Tên NV";
            this.Tennv.Width = 170;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Text = "Ngày sinh";
            this.Ngaysinh.Width = 184;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 52);
            this.button3.TabIndex = 28;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 52);
            this.button2.TabIndex = 27;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 52);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNgaysinh
            // 
            this.textBoxNgaysinh.Location = new System.Drawing.Point(378, 120);
            this.textBoxNgaysinh.Name = "textBoxNgaysinh";
            this.textBoxNgaysinh.Size = new System.Drawing.Size(438, 37);
            this.textBoxNgaysinh.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            // 
            // textBoxTennv
            // 
            this.textBoxTennv.Location = new System.Drawing.Point(378, 76);
            this.textBoxTennv.Name = "textBoxTennv";
            this.textBoxTennv.Size = new System.Drawing.Size(438, 37);
            this.textBoxTennv.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // textBoxManv
            // 
            this.textBoxManv.Location = new System.Drawing.Point(378, 34);
            this.textBoxManv.Name = "textBoxManv";
            this.textBoxManv.Size = new System.Drawing.Size(438, 37);
            this.textBoxManv.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "label4";
            // 
            // comboBoxMaph
            // 
            this.comboBoxMaph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaph.FormattingEnabled = true;
            this.comboBoxMaph.Location = new System.Drawing.Point(378, 162);
            this.comboBoxMaph.Name = "comboBoxMaph";
            this.comboBoxMaph.Size = new System.Drawing.Size(438, 37);
            this.comboBoxMaph.TabIndex = 31;
            // 
            // comboBoxMacv
            // 
            this.comboBoxMacv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMacv.FormattingEnabled = true;
            this.comboBoxMacv.Location = new System.Drawing.Point(378, 205);
            this.comboBoxMacv.Name = "comboBoxMacv";
            this.comboBoxMacv.Size = new System.Drawing.Size(438, 37);
            this.comboBoxMacv.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "label5";
            // 
            // Maph
            // 
            this.Maph.Text = "Mã Ph";
            this.Maph.Width = 128;
            // 
            // Macv
            // 
            this.Macv.Text = "Mã CV";
            this.Macv.Width = 123;
            // 
            // Luong
            // 
            this.Luong.Text = "Lương";
            this.Luong.Width = 132;
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Location = new System.Drawing.Point(378, 249);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(438, 37);
            this.textBoxLuong.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "label6";
            // 
            // FormNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.textBoxLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMacv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMaph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNgaysinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxManv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormNhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.FormNhanvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Manv;
        private System.Windows.Forms.ColumnHeader Tennv;
        private System.Windows.Forms.ColumnHeader Ngaysinh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNgaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxManv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMaph;
        private System.Windows.Forms.ComboBox comboBoxMacv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Maph;
        private System.Windows.Forms.ColumnHeader Macv;
        private System.Windows.Forms.ColumnHeader Luong;
        private System.Windows.Forms.TextBox textBoxLuong;
        private System.Windows.Forms.Label label6;
    }
}