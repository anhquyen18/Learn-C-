
namespace Bai37
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KhachHangLB = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.thoatBt = new System.Windows.Forms.Button();
            this.huyBt = new System.Windows.Forms.Button();
            this.chonBt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tongTienLb = new System.Windows.Forms.Label();
            this.thanhTienLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gheTLP = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình đặt vé xem phim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 416);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KhachHangLB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người đặt vé:";
            // 
            // KhachHangLB
            // 
            this.KhachHangLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KhachHangLB.FormattingEnabled = true;
            this.KhachHangLB.ItemHeight = 16;
            this.KhachHangLB.Location = new System.Drawing.Point(3, 18);
            this.KhachHangLB.Name = "KhachHangLB";
            this.KhachHangLB.Size = new System.Drawing.Size(194, 395);
            this.KhachHangLB.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.thoatBt);
            this.panel3.Controls.Add(this.huyBt);
            this.panel3.Controls.Add(this.chonBt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tongTienLb);
            this.panel3.Controls.Add(this.thanhTienLb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 100);
            this.panel3.TabIndex = 2;
            // 
            // thoatBt
            // 
            this.thoatBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatBt.Location = new System.Drawing.Point(337, 61);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(75, 36);
            this.thoatBt.TabIndex = 1;
            this.thoatBt.Text = "Thoát";
            this.thoatBt.UseVisualStyleBackColor = true;
            // 
            // huyBt
            // 
            this.huyBt.Location = new System.Drawing.Point(111, 61);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(75, 32);
            this.huyBt.TabIndex = 1;
            this.huyBt.Text = "Hủy";
            this.huyBt.UseVisualStyleBackColor = true;
            // 
            // chonBt
            // 
            this.chonBt.Location = new System.Drawing.Point(8, 61);
            this.chonBt.Name = "chonBt";
            this.chonBt.Size = new System.Drawing.Size(75, 32);
            this.chonBt.TabIndex = 1;
            this.chonBt.Text = "Chọn";
            this.chonBt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng thành tiền:";
            // 
            // tongTienLb
            // 
            this.tongTienLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tongTienLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tongTienLb.ForeColor = System.Drawing.Color.OrangeRed;
            this.tongTienLb.Location = new System.Drawing.Point(126, 34);
            this.tongTienLb.Name = "tongTienLb";
            this.tongTienLb.Size = new System.Drawing.Size(277, 20);
            this.tongTienLb.TabIndex = 0;
            this.tongTienLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thanhTienLb
            // 
            this.thanhTienLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thanhTienLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thanhTienLb.ForeColor = System.Drawing.Color.OrangeRed;
            this.thanhTienLb.Location = new System.Drawing.Point(126, 3);
            this.thanhTienLb.Name = "thanhTienLb";
            this.thanhTienLb.Size = new System.Drawing.Size(277, 20);
            this.thanhTienLb.TabIndex = 0;
            this.thanhTienLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thành tiền:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 316);
            this.panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gheTLP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 316);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màn ảnh:";
            // 
            // gheTLP
            // 
            this.gheTLP.ColumnCount = 10;
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gheTLP.Location = new System.Drawing.Point(3, 18);
            this.gheTLP.Name = "gheTLP";
            this.gheTLP.RowCount = 10;
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gheTLP.Size = new System.Drawing.Size(409, 295);
            this.gheTLP.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 485);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox KhachHangLB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Button chonBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tongTienLb;
        private System.Windows.Forms.Label thanhTienLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel gheTLP;
    }
}

