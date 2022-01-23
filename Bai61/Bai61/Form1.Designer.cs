
namespace Bai61
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
            this.btDemSoSanPham = new System.Windows.Forms.Button();
            this.lbTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhapMa = new System.Windows.Forms.TextBox();
            this.btXemChiTiet = new System.Windows.Forms.Button();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbGiaSP = new System.Windows.Forms.TextBox();
            this.btXemChiTiet2 = new System.Windows.Forms.Button();
            this.btHienThiDanhSach = new System.Windows.Forms.Button();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btDemSoSanPham
            // 
            this.btDemSoSanPham.AutoSize = true;
            this.btDemSoSanPham.Location = new System.Drawing.Point(35, 12);
            this.btDemSoSanPham.Name = "btDemSoSanPham";
            this.btDemSoSanPham.Size = new System.Drawing.Size(230, 39);
            this.btDemSoSanPham.TabIndex = 0;
            this.btDemSoSanPham.Text = "Đếm số sản phẩm";
            this.btDemSoSanPham.UseVisualStyleBackColor = true;
            this.btDemSoSanPham.Click += new System.EventHandler(this.btDemSoSanPham_Click);
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(305, 17);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(0, 29);
            this.lbTest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã sp:";
            // 
            // tbNhapMa
            // 
            this.tbNhapMa.Location = new System.Drawing.Point(216, 74);
            this.tbNhapMa.Name = "tbNhapMa";
            this.tbNhapMa.Size = new System.Drawing.Size(111, 36);
            this.tbNhapMa.TabIndex = 2;
            // 
            // btXemChiTiet
            // 
            this.btXemChiTiet.AutoSize = true;
            this.btXemChiTiet.Location = new System.Drawing.Point(35, 129);
            this.btXemChiTiet.Name = "btXemChiTiet";
            this.btXemChiTiet.Size = new System.Drawing.Size(276, 39);
            this.btXemChiTiet.TabIndex = 0;
            this.btXemChiTiet.Text = "Xem chi tiết sản phẩm";
            this.btXemChiTiet.UseVisualStyleBackColor = true;
            this.btXemChiTiet.Click += new System.EventHandler(this.btXemChiTiet_Click);
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(81, 195);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(533, 36);
            this.tbMaSP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá:";
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(81, 246);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(533, 36);
            this.tbTenSP.TabIndex = 2;
            // 
            // tbGiaSP
            // 
            this.tbGiaSP.Location = new System.Drawing.Point(81, 292);
            this.tbGiaSP.Name = "tbGiaSP";
            this.tbGiaSP.Size = new System.Drawing.Size(533, 36);
            this.tbGiaSP.TabIndex = 2;
            // 
            // btXemChiTiet2
            // 
            this.btXemChiTiet2.AutoSize = true;
            this.btXemChiTiet2.Location = new System.Drawing.Point(317, 129);
            this.btXemChiTiet2.Name = "btXemChiTiet2";
            this.btXemChiTiet2.Size = new System.Drawing.Size(297, 39);
            this.btXemChiTiet2.TabIndex = 0;
            this.btXemChiTiet2.Text = "Xem chi tiết sản phẩm 2";
            this.btXemChiTiet2.UseVisualStyleBackColor = true;
            this.btXemChiTiet2.Click += new System.EventHandler(this.btXemChiTiet2_Click);
            // 
            // btHienThiDanhSach
            // 
            this.btHienThiDanhSach.AutoSize = true;
            this.btHienThiDanhSach.Location = new System.Drawing.Point(677, 17);
            this.btHienThiDanhSach.Name = "btHienThiDanhSach";
            this.btHienThiDanhSach.Size = new System.Drawing.Size(352, 39);
            this.btHienThiDanhSach.TabIndex = 0;
            this.btHienThiDanhSach.Text = "Hiển thị danh sách sản phẩm";
            this.btHienThiDanhSach.UseVisualStyleBackColor = true;
            this.btHienThiDanhSach.Click += new System.EventHandler(this.btHienThiDanhSach_Click);
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(656, 97);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(398, 268);
            this.lvSanPham.TabIndex = 3;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Don Gia";
            this.columnHeader3.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 433);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.tbGiaSP);
            this.Controls.Add(this.tbTenSP);
            this.Controls.Add(this.tbMaSP);
            this.Controls.Add(this.tbNhapMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.btHienThiDanhSach);
            this.Controls.Add(this.btXemChiTiet2);
            this.Controls.Add(this.btXemChiTiet);
            this.Controls.Add(this.btDemSoSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDemSoSanPham;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNhapMa;
        private System.Windows.Forms.Button btXemChiTiet;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbGiaSP;
        private System.Windows.Forms.Button btXemChiTiet2;
        private System.Windows.Forms.Button btHienThiDanhSach;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

