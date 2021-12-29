
namespace Bai35
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLaSinhVien = new System.Windows.Forms.CheckBox();
            this.tbSoLuongSach = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.tbTongSoKhachSV = new System.Windows.Forms.TextBox();
            this.tbTongSoKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btTinhTien = new System.Windows.Forms.Button();
            this.btTiep = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính tiền bán sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLaSinhVien);
            this.groupBox1.Controls.Add(this.tbSoLuongSach);
            this.groupBox1.Controls.Add(this.tbTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbThanhTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn:";
            // 
            // cbLaSinhVien
            // 
            this.cbLaSinhVien.AutoSize = true;
            this.cbLaSinhVien.Location = new System.Drawing.Point(260, 129);
            this.cbLaSinhVien.Name = "cbLaSinhVien";
            this.cbLaSinhVien.Size = new System.Drawing.Size(18, 17);
            this.cbLaSinhVien.TabIndex = 4;
            this.cbLaSinhVien.UseVisualStyleBackColor = true;
            this.cbLaSinhVien.CheckedChanged += new System.EventHandler(this.cbLaSinhVien_CheckedChanged);
            // 
            // tbSoLuongSach
            // 
            this.tbSoLuongSach.Location = new System.Drawing.Point(243, 74);
            this.tbSoLuongSach.Name = "tbSoLuongSach";
            this.tbSoLuongSach.Size = new System.Drawing.Size(324, 36);
            this.tbSoLuongSach.TabIndex = 3;
            this.tbSoLuongSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(243, 29);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(324, 36);
            this.tbTenKH.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng sách:";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbThanhTien.Enabled = false;
            this.lbThanhTien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbThanhTien.Location = new System.Drawing.Point(243, 174);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(324, 29);
            this.lbThanhTien.TabIndex = 5;
            this.lbThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thành tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khách hàng là SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbTongDoanhThu);
            this.groupBox3.Controls.Add(this.tbTongSoKhachSV);
            this.groupBox3.Controls.Add(this.tbTongSoKhach);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(5, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng doanh thu:";
            // 
            // tbTongDoanhThu
            // 
            this.tbTongDoanhThu.Location = new System.Drawing.Point(240, 132);
            this.tbTongDoanhThu.Name = "tbTongDoanhThu";
            this.tbTongDoanhThu.ReadOnly = true;
            this.tbTongDoanhThu.Size = new System.Drawing.Size(340, 36);
            this.tbTongDoanhThu.TabIndex = 2;
            this.tbTongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTongSoKhachSV
            // 
            this.tbTongSoKhachSV.Location = new System.Drawing.Point(240, 83);
            this.tbTongSoKhachSV.Name = "tbTongSoKhachSV";
            this.tbTongSoKhachSV.ReadOnly = true;
            this.tbTongSoKhachSV.Size = new System.Drawing.Size(340, 36);
            this.tbTongSoKhachSV.TabIndex = 1;
            this.tbTongSoKhachSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTongSoKhachSV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbTongSoKhachSV_MouseDoubleClick);
            // 
            // tbTongSoKhach
            // 
            this.tbTongSoKhach.Location = new System.Drawing.Point(240, 38);
            this.tbTongSoKhach.Name = "tbTongSoKhach";
            this.tbTongSoKhach.ReadOnly = true;
            this.tbTongSoKhach.Size = new System.Drawing.Size(340, 36);
            this.tbTongSoKhach.TabIndex = 0;
            this.tbTongSoKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTongSoKhach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbTongSoKhach_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng số khách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tổng số khách SV:";
            // 
            // btTinhTien
            // 
            this.btTinhTien.AutoSize = true;
            this.btTinhTien.Location = new System.Drawing.Point(10, 22);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Size = new System.Drawing.Size(120, 39);
            this.btTinhTien.TabIndex = 0;
            this.btTinhTien.Text = "Tính tiền";
            this.btTinhTien.UseVisualStyleBackColor = true;
            this.btTinhTien.Click += new System.EventHandler(this.btTinhTien_Click);
            // 
            // btTiep
            // 
            this.btTiep.AutoSize = true;
            this.btTiep.Location = new System.Drawing.Point(164, 22);
            this.btTiep.Name = "btTiep";
            this.btTiep.Size = new System.Drawing.Size(97, 39);
            this.btTiep.TabIndex = 1;
            this.btTiep.Text = "Tiếp";
            this.btTiep.UseVisualStyleBackColor = true;
            this.btTiep.Click += new System.EventHandler(this.btTiep_Click);
            // 
            // btThongKe
            // 
            this.btThongKe.AutoSize = true;
            this.btThongKe.Location = new System.Drawing.Point(295, 22);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(128, 39);
            this.btThongKe.TabIndex = 2;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Location = new System.Drawing.Point(457, 22);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(97, 39);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btThongKe);
            this.groupBox2.Controls.Add(this.btTiep);
            this.groupBox2.Controls.Add(this.btTinhTien);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLaSinhVien;
        private System.Windows.Forms.TextBox tbSoLuongSach;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTongDoanhThu;
        private System.Windows.Forms.TextBox tbTongSoKhachSV;
        private System.Windows.Forms.TextBox tbTongSoKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btTinhTien;
        private System.Windows.Forms.Button btTiep;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

