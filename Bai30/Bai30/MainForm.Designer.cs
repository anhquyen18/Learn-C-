
namespace Bai30
{
    partial class MainForm
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
            this.soTB = new System.Windows.Forms.TextBox();
            this.capNhatBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chonLeBt = new System.Windows.Forms.Button();
            this.chonChanBt = new System.Windows.Forms.Button();
            this.xoaDangChonBt = new System.Windows.Forms.Button();
            this.binhPhuongBt = new System.Windows.Forms.Button();
            this.tang2Bt = new System.Windows.Forms.Button();
            this.xoaDauCuoiBt = new System.Windows.Forms.Button();
            this.tongBT = new System.Windows.Forms.Button();
            this.ketThucBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // soTB
            // 
            this.soTB.Location = new System.Drawing.Point(100, 23);
            this.soTB.Name = "soTB";
            this.soTB.Size = new System.Drawing.Size(287, 22);
            this.soTB.TabIndex = 1;
            // 
            // capNhatBt
            // 
            this.capNhatBt.AutoSize = true;
            this.capNhatBt.Location = new System.Drawing.Point(417, 21);
            this.capNhatBt.Name = "capNhatBt";
            this.capNhatBt.Size = new System.Drawing.Size(75, 27);
            this.capNhatBt.TabIndex = 2;
            this.capNhatBt.Text = "Cập nhật";
            this.capNhatBt.UseVisualStyleBackColor = true;
            this.capNhatBt.Click += new System.EventHandler(this.capNhatBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.soLB);
            this.groupBox1.Location = new System.Drawing.Point(26, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách số";
            // 
            // soLB
            // 
            this.soLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soLB.FormattingEnabled = true;
            this.soLB.ItemHeight = 16;
            this.soLB.Location = new System.Drawing.Point(3, 18);
            this.soLB.Name = "soLB";
            this.soLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.soLB.Size = new System.Drawing.Size(194, 223);
            this.soLB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chonLeBt);
            this.groupBox2.Controls.Add(this.chonChanBt);
            this.groupBox2.Controls.Add(this.xoaDangChonBt);
            this.groupBox2.Controls.Add(this.binhPhuongBt);
            this.groupBox2.Controls.Add(this.tang2Bt);
            this.groupBox2.Controls.Add(this.xoaDauCuoiBt);
            this.groupBox2.Controls.Add(this.tongBT);
            this.groupBox2.Location = new System.Drawing.Point(252, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 244);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng";
            // 
            // chonLeBt
            // 
            this.chonLeBt.AutoSize = true;
            this.chonLeBt.Location = new System.Drawing.Point(7, 198);
            this.chonLeBt.Name = "chonLeBt";
            this.chonLeBt.Size = new System.Drawing.Size(233, 27);
            this.chonLeBt.TabIndex = 6;
            this.chonLeBt.Text = "Chọn số lẻ";
            this.chonLeBt.UseVisualStyleBackColor = true;
            this.chonLeBt.Click += new System.EventHandler(this.chonLeBt_Click);
            // 
            // chonChanBt
            // 
            this.chonChanBt.AutoSize = true;
            this.chonChanBt.Location = new System.Drawing.Point(7, 170);
            this.chonChanBt.Name = "chonChanBt";
            this.chonChanBt.Size = new System.Drawing.Size(233, 27);
            this.chonChanBt.TabIndex = 5;
            this.chonChanBt.Text = "Chọn số chẵn";
            this.chonChanBt.UseVisualStyleBackColor = true;
            this.chonChanBt.Click += new System.EventHandler(this.chonChanBt_Click);
            // 
            // xoaDangChonBt
            // 
            this.xoaDangChonBt.AutoSize = true;
            this.xoaDangChonBt.Location = new System.Drawing.Point(7, 86);
            this.xoaDangChonBt.Name = "xoaDangChonBt";
            this.xoaDangChonBt.Size = new System.Drawing.Size(233, 27);
            this.xoaDangChonBt.TabIndex = 2;
            this.xoaDangChonBt.Text = "Xóa phần tử đang chọn";
            this.xoaDangChonBt.UseVisualStyleBackColor = true;
            this.xoaDangChonBt.Click += new System.EventHandler(this.xoaDangChonBt_Click);
            // 
            // binhPhuongBt
            // 
            this.binhPhuongBt.AutoSize = true;
            this.binhPhuongBt.Location = new System.Drawing.Point(7, 142);
            this.binhPhuongBt.Name = "binhPhuongBt";
            this.binhPhuongBt.Size = new System.Drawing.Size(233, 27);
            this.binhPhuongBt.TabIndex = 4;
            this.binhPhuongBt.Text = "Thay bằng bình phương";
            this.binhPhuongBt.UseVisualStyleBackColor = true;
            this.binhPhuongBt.Click += new System.EventHandler(this.binhPhuongBt_Click);
            // 
            // tang2Bt
            // 
            this.tang2Bt.AutoSize = true;
            this.tang2Bt.Location = new System.Drawing.Point(7, 114);
            this.tang2Bt.Name = "tang2Bt";
            this.tang2Bt.Size = new System.Drawing.Size(233, 27);
            this.tang2Bt.TabIndex = 3;
            this.tang2Bt.Text = "Tăng mỗi phần tử lên 2";
            this.tang2Bt.UseVisualStyleBackColor = true;
            this.tang2Bt.Click += new System.EventHandler(this.tang2Bt_Click);
            // 
            // xoaDauCuoiBt
            // 
            this.xoaDauCuoiBt.AutoSize = true;
            this.xoaDauCuoiBt.Location = new System.Drawing.Point(7, 58);
            this.xoaDauCuoiBt.Name = "xoaDauCuoiBt";
            this.xoaDauCuoiBt.Size = new System.Drawing.Size(233, 27);
            this.xoaDauCuoiBt.TabIndex = 1;
            this.xoaDauCuoiBt.Text = "Xóa phần từ đầu và cuối";
            this.xoaDauCuoiBt.UseVisualStyleBackColor = true;
            this.xoaDauCuoiBt.Click += new System.EventHandler(this.xoaDauCuoiBt_Click);
            // 
            // tongBT
            // 
            this.tongBT.AutoSize = true;
            this.tongBT.Location = new System.Drawing.Point(7, 30);
            this.tongBT.Name = "tongBT";
            this.tongBT.Size = new System.Drawing.Size(233, 27);
            this.tongBT.TabIndex = 0;
            this.tongBT.Text = "Tổng của danh sách";
            this.tongBT.UseVisualStyleBackColor = true;
            this.tongBT.Click += new System.EventHandler(this.tongBT_Click);
            // 
            // ketThucBt
            // 
            this.ketThucBt.Location = new System.Drawing.Point(26, 333);
            this.ketThucBt.Name = "ketThucBt";
            this.ketThucBt.Size = new System.Drawing.Size(477, 23);
            this.ketThucBt.TabIndex = 5;
            this.ketThucBt.Text = "Kết thúc chương trình";
            this.ketThucBt.UseVisualStyleBackColor = true;
            this.ketThucBt.Click += new System.EventHandler(this.ketThucBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 368);
            this.Controls.Add(this.ketThucBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.capNhatBt);
            this.Controls.Add(this.soTB);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Bài tập về ListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soTB;
        private System.Windows.Forms.Button capNhatBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox soLB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button chonLeBt;
        private System.Windows.Forms.Button chonChanBt;
        private System.Windows.Forms.Button xoaDangChonBt;
        private System.Windows.Forms.Button binhPhuongBt;
        private System.Windows.Forms.Button tang2Bt;
        private System.Windows.Forms.Button xoaDauCuoiBt;
        private System.Windows.Forms.Button tongBT;
        private System.Windows.Forms.Button ketThucBt;
    }
}

