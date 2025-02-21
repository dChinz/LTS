namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonPhong = new System.Windows.Forms.Button();
            this.buttonChucvu = new System.Windows.Forms.Button();
            this.buttonNhanvien = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPhong
            // 
            this.buttonPhong.Location = new System.Drawing.Point(51, 73);
            this.buttonPhong.Name = "buttonPhong";
            this.buttonPhong.Size = new System.Drawing.Size(155, 81);
            this.buttonPhong.TabIndex = 0;
            this.buttonPhong.Text = "Phòng";
            this.buttonPhong.UseVisualStyleBackColor = true;
            this.buttonPhong.Click += new System.EventHandler(this.buttonPhong_Click);
            // 
            // buttonChucvu
            // 
            this.buttonChucvu.Location = new System.Drawing.Point(245, 73);
            this.buttonChucvu.Name = "buttonChucvu";
            this.buttonChucvu.Size = new System.Drawing.Size(155, 81);
            this.buttonChucvu.TabIndex = 1;
            this.buttonChucvu.Text = "Chức vụ";
            this.buttonChucvu.UseVisualStyleBackColor = true;
            this.buttonChucvu.Click += new System.EventHandler(this.buttonChucvu_Click);
            // 
            // buttonNhanvien
            // 
            this.buttonNhanvien.Location = new System.Drawing.Point(438, 73);
            this.buttonNhanvien.Name = "buttonNhanvien";
            this.buttonNhanvien.Size = new System.Drawing.Size(155, 81);
            this.buttonNhanvien.TabIndex = 2;
            this.buttonNhanvien.Text = "Nhân viên";
            this.buttonNhanvien.UseVisualStyleBackColor = true;
            this.buttonNhanvien.Click += new System.EventHandler(this.buttonNhanvien_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(618, 73);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(155, 81);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 566);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonNhanvien);
            this.Controls.Add(this.buttonChucvu);
            this.Controls.Add(this.buttonPhong);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPhong;
        private System.Windows.Forms.Button buttonChucvu;
        private System.Windows.Forms.Button buttonNhanvien;
        private System.Windows.Forms.Button buttonReport;
    }
}

