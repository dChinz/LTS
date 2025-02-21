namespace WindowsFormsApp1
{
    partial class FormChucvu
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
            this.Macv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tencv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ttc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTtc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTencv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMacv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Macv,
            this.Tencv,
            this.Ttc});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(79, 355);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1086, 263);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Macv
            // 
            this.Macv.Text = "Mã CV";
            this.Macv.Width = 166;
            // 
            // Tencv
            // 
            this.Tencv.Text = "Tên CV";
            this.Tencv.Width = 170;
            // 
            // Ttc
            // 
            this.Ttc.Text = "Tiền tc";
            this.Ttc.Width = 184;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 52);
            this.button3.TabIndex = 18;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTtc
            // 
            this.textBoxTtc.Location = new System.Drawing.Point(378, 165);
            this.textBoxTtc.Name = "textBoxTtc";
            this.textBoxTtc.Size = new System.Drawing.Size(438, 37);
            this.textBoxTtc.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // textBoxTencv
            // 
            this.textBoxTencv.Location = new System.Drawing.Point(378, 101);
            this.textBoxTencv.Name = "textBoxTencv";
            this.textBoxTencv.Size = new System.Drawing.Size(438, 37);
            this.textBoxTencv.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // textBoxMacv
            // 
            this.textBoxMacv.Location = new System.Drawing.Point(378, 34);
            this.textBoxMacv.Name = "textBoxMacv";
            this.textBoxMacv.Size = new System.Drawing.Size(438, 37);
            this.textBoxMacv.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // FormChucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTencv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMacv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormChucvu";
            this.Text = "Chucvu";
            this.Load += new System.EventHandler(this.Chucvu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Macv;
        private System.Windows.Forms.ColumnHeader Tencv;
        private System.Windows.Forms.ColumnHeader Ttc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTtc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTencv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMacv;
        private System.Windows.Forms.Label label1;
    }
}