
namespace Bai62
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
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbDanhMuc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.lvSanPham.Location = new System.Drawing.Point(12, 12);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(361, 426);
            this.lvSanPham.TabIndex = 0;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDanhMuc);
            this.groupBox1.Controls.Add(this.tbGia);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.tbMa);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(421, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh Mục:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(65, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lưu không dùng Parameter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(123, 42);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(179, 22);
            this.tbMa.TabIndex = 2;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(123, 85);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(179, 22);
            this.tbTen.TabIndex = 2;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(123, 141);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(179, 22);
            this.tbGia.TabIndex = 2;
            // 
            // tbDanhMuc
            // 
            this.tbDanhMuc.Location = new System.Drawing.Point(123, 202);
            this.tbDanhMuc.Name = "tbDanhMuc";
            this.tbDanhMuc.Size = new System.Drawing.Size(179, 22);
            this.tbDanhMuc.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(65, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lưu có dùng Parameter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvSanPham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDanhMuc;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

