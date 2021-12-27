
namespace Bai33
{
    partial class FormDanhMuc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhMucLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thoatBt = new System.Windows.Forms.Button();
            this.XoaBt = new System.Windows.Forms.Button();
            this.LuuBt = new System.Windows.Forms.Button();
            this.tenDMTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maDMTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.danhMucLB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách danh mục:";
            // 
            // danhMucLB
            // 
            this.danhMucLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhMucLB.FormattingEnabled = true;
            this.danhMucLB.ItemHeight = 16;
            this.danhMucLB.Location = new System.Drawing.Point(3, 18);
            this.danhMucLB.Name = "danhMucLB";
            this.danhMucLB.Size = new System.Drawing.Size(233, 287);
            this.danhMucLB.TabIndex = 0;
            this.danhMucLB.SelectedIndexChanged += new System.EventHandler(this.danhMucLB_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thoatBt);
            this.groupBox2.Controls.Add(this.XoaBt);
            this.groupBox2.Controls.Add(this.LuuBt);
            this.groupBox2.Controls.Add(this.tenDMTB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maDMTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(242, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết danh mục:";
            // 
            // thoatBt
            // 
            this.thoatBt.AutoSize = true;
            this.thoatBt.Location = new System.Drawing.Point(170, 254);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(75, 27);
            this.thoatBt.TabIndex = 6;
            this.thoatBt.Text = "Đóng";
            this.thoatBt.UseVisualStyleBackColor = true;
            this.thoatBt.Click += new System.EventHandler(this.dongBt_Click);
            // 
            // XoaBt
            // 
            this.XoaBt.AutoSize = true;
            this.XoaBt.Location = new System.Drawing.Point(91, 254);
            this.XoaBt.Name = "XoaBt";
            this.XoaBt.Size = new System.Drawing.Size(75, 27);
            this.XoaBt.TabIndex = 5;
            this.XoaBt.Text = "Xóa";
            this.XoaBt.UseVisualStyleBackColor = true;
            this.XoaBt.Click += new System.EventHandler(this.XoaBt_Click);
            // 
            // LuuBt
            // 
            this.LuuBt.AutoSize = true;
            this.LuuBt.Location = new System.Drawing.Point(10, 254);
            this.LuuBt.Name = "LuuBt";
            this.LuuBt.Size = new System.Drawing.Size(75, 27);
            this.LuuBt.TabIndex = 4;
            this.LuuBt.Text = "Lưu";
            this.LuuBt.UseVisualStyleBackColor = true;
            this.LuuBt.Click += new System.EventHandler(this.LuuBt_Click);
            // 
            // tenDMTB
            // 
            this.tenDMTB.Location = new System.Drawing.Point(7, 169);
            this.tenDMTB.Name = "tenDMTB";
            this.tenDMTB.Size = new System.Drawing.Size(236, 22);
            this.tenDMTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên danh mục:";
            // 
            // maDMTB
            // 
            this.maDMTB.Location = new System.Drawing.Point(7, 80);
            this.maDMTB.Name = "maDMTB";
            this.maDMTB.Size = new System.Drawing.Size(236, 22);
            this.maDMTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã danh mục:";
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox danhMucLB;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.Button XoaBt;
        private System.Windows.Forms.Button LuuBt;
        private System.Windows.Forms.TextBox tenDMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maDMTB;
        private System.Windows.Forms.Label label1;
    }
}