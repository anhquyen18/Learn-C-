
namespace Bai33
{
    partial class FormSanPham
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhSachLB = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xuatXuTB = new System.Windows.Forms.TextBox();
            this.donGiaTB = new System.Windows.Forms.TextBox();
            this.tenSPTB = new System.Windows.Forms.TextBox();
            this.maSPTB = new System.Windows.Forms.TextBox();
            this.hanSDDTP = new System.Windows.Forms.DateTimePicker();
            this.thoatBt = new System.Windows.Forms.Button();
            this.xoaBt = new System.Windows.Forms.Button();
            this.luuBt = new System.Windows.Forms.Button();
            this.quanLyDMBt = new System.Windows.Forms.Button();
            this.danhMucCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình quản lý sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(601, 330);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhSachLB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm:";
            // 
            // danhSachLB
            // 
            this.danhSachLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhSachLB.FormattingEnabled = true;
            this.danhSachLB.ItemHeight = 16;
            this.danhSachLB.Location = new System.Drawing.Point(3, 18);
            this.danhSachLB.Name = "danhSachLB";
            this.danhSachLB.Size = new System.Drawing.Size(250, 309);
            this.danhSachLB.TabIndex = 0;
            this.danhSachLB.SelectedIndexChanged += new System.EventHandler(this.danhSachLB_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 330);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xuatXuTB);
            this.groupBox2.Controls.Add(this.donGiaTB);
            this.groupBox2.Controls.Add(this.tenSPTB);
            this.groupBox2.Controls.Add(this.maSPTB);
            this.groupBox2.Controls.Add(this.hanSDDTP);
            this.groupBox2.Controls.Add(this.thoatBt);
            this.groupBox2.Controls.Add(this.xoaBt);
            this.groupBox2.Controls.Add(this.luuBt);
            this.groupBox2.Controls.Add(this.quanLyDMBt);
            this.groupBox2.Controls.Add(this.danhMucCB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 330);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết:";
            // 
            // xuatXuTB
            // 
            this.xuatXuTB.Location = new System.Drawing.Point(108, 202);
            this.xuatXuTB.Name = "xuatXuTB";
            this.xuatXuTB.Size = new System.Drawing.Size(221, 22);
            this.xuatXuTB.TabIndex = 10;
            // 
            // donGiaTB
            // 
            this.donGiaTB.Location = new System.Drawing.Point(109, 156);
            this.donGiaTB.Name = "donGiaTB";
            this.donGiaTB.Size = new System.Drawing.Size(221, 22);
            this.donGiaTB.TabIndex = 9;
            // 
            // tenSPTB
            // 
            this.tenSPTB.Location = new System.Drawing.Point(108, 111);
            this.tenSPTB.Name = "tenSPTB";
            this.tenSPTB.Size = new System.Drawing.Size(221, 22);
            this.tenSPTB.TabIndex = 8;
            // 
            // maSPTB
            // 
            this.maSPTB.Location = new System.Drawing.Point(109, 67);
            this.maSPTB.Name = "maSPTB";
            this.maSPTB.Size = new System.Drawing.Size(221, 22);
            this.maSPTB.TabIndex = 7;
            // 
            // hanSDDTP
            // 
            this.hanSDDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hanSDDTP.Location = new System.Drawing.Point(109, 248);
            this.hanSDDTP.Name = "hanSDDTP";
            this.hanSDDTP.Size = new System.Drawing.Size(220, 22);
            this.hanSDDTP.TabIndex = 11;
            // 
            // thoatBt
            // 
            this.thoatBt.AutoSize = true;
            this.thoatBt.Location = new System.Drawing.Point(254, 291);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(75, 27);
            this.thoatBt.TabIndex = 14;
            this.thoatBt.Text = "Thoát";
            this.thoatBt.UseVisualStyleBackColor = true;
            // 
            // xoaBt
            // 
            this.xoaBt.AutoSize = true;
            this.xoaBt.Location = new System.Drawing.Point(141, 291);
            this.xoaBt.Name = "xoaBt";
            this.xoaBt.Size = new System.Drawing.Size(75, 27);
            this.xoaBt.TabIndex = 13;
            this.xoaBt.Text = "Xóa";
            this.xoaBt.UseVisualStyleBackColor = true;
            this.xoaBt.Click += new System.EventHandler(this.xoaBt_Click);
            // 
            // luuBt
            // 
            this.luuBt.AutoSize = true;
            this.luuBt.Location = new System.Drawing.Point(29, 291);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(75, 27);
            this.luuBt.TabIndex = 12;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // quanLyDMBt
            // 
            this.quanLyDMBt.AutoSize = true;
            this.quanLyDMBt.Location = new System.Drawing.Point(255, 16);
            this.quanLyDMBt.Name = "quanLyDMBt";
            this.quanLyDMBt.Size = new System.Drawing.Size(75, 27);
            this.quanLyDMBt.TabIndex = 15;
            this.quanLyDMBt.Text = "...";
            this.quanLyDMBt.UseVisualStyleBackColor = true;
            this.quanLyDMBt.Click += new System.EventHandler(this.quanLyDMBt_Click);
            // 
            // danhMucCB
            // 
            this.danhMucCB.FormattingEnabled = true;
            this.danhMucCB.Location = new System.Drawing.Point(109, 18);
            this.danhMucCB.Name = "danhMucCB";
            this.danhMucCB.Size = new System.Drawing.Size(140, 24);
            this.danhMucCB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hạn SD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Xuất xứ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục:";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(601, 378);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý sản phẩm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox danhSachLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker hanSDDTP;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.Button xoaBt;
        private System.Windows.Forms.Button luuBt;
        private System.Windows.Forms.Button quanLyDMBt;
        private System.Windows.Forms.ComboBox danhMucCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xuatXuTB;
        private System.Windows.Forms.TextBox donGiaTB;
        private System.Windows.Forms.TextBox tenSPTB;
        private System.Windows.Forms.TextBox maSPTB;
    }
}

