
namespace Bai48
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "sp1",
            "Vinamilk",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "sp2",
            "Kẹo sữa",
            "20"}, -1);
            this.sanPhamLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maTB = new System.Windows.Forms.TextBox();
            this.sanPhamTB = new System.Windows.Forms.TextBox();
            this.donGiaTB = new System.Windows.Forms.TextBox();
            this.themSanPhamBt = new System.Windows.Forms.Button();
            this.xoaBt = new System.Windows.Forms.Button();
            this.suaBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sanPhamLV
            // 
            this.sanPhamLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.sanPhamLV.FullRowSelect = true;
            this.sanPhamLV.GridLines = true;
            this.sanPhamLV.HideSelection = false;
            this.sanPhamLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.sanPhamLV.Location = new System.Drawing.Point(12, 220);
            this.sanPhamLV.Name = "sanPhamLV";
            this.sanPhamLV.Size = new System.Drawing.Size(413, 225);
            this.sanPhamLV.TabIndex = 0;
            this.sanPhamLV.UseCompatibleStateImageBehavior = false;
            this.sanPhamLV.View = System.Windows.Forms.View.Details;
            this.sanPhamLV.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.sanPhamLV_ColumnClick);
            this.sanPhamLV.SelectedIndexChanged += new System.EventHandler(this.sanPhamLV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sản phẩm";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn giá:";
            // 
            // maTB
            // 
            this.maTB.Location = new System.Drawing.Point(150, 46);
            this.maTB.Name = "maTB";
            this.maTB.Size = new System.Drawing.Size(264, 22);
            this.maTB.TabIndex = 2;
            // 
            // sanPhamTB
            // 
            this.sanPhamTB.Location = new System.Drawing.Point(150, 74);
            this.sanPhamTB.Name = "sanPhamTB";
            this.sanPhamTB.Size = new System.Drawing.Size(264, 22);
            this.sanPhamTB.TabIndex = 2;
            // 
            // donGiaTB
            // 
            this.donGiaTB.Location = new System.Drawing.Point(150, 102);
            this.donGiaTB.Name = "donGiaTB";
            this.donGiaTB.Size = new System.Drawing.Size(264, 22);
            this.donGiaTB.TabIndex = 2;
            // 
            // themSanPhamBt
            // 
            this.themSanPhamBt.AutoSize = true;
            this.themSanPhamBt.Location = new System.Drawing.Point(150, 153);
            this.themSanPhamBt.Name = "themSanPhamBt";
            this.themSanPhamBt.Size = new System.Drawing.Size(120, 27);
            this.themSanPhamBt.TabIndex = 3;
            this.themSanPhamBt.Text = "Thêm sản phẩm";
            this.themSanPhamBt.UseVisualStyleBackColor = true;
            this.themSanPhamBt.Click += new System.EventHandler(this.themSanPhamBt_Click);
            // 
            // xoaBt
            // 
            this.xoaBt.AutoSize = true;
            this.xoaBt.Location = new System.Drawing.Point(294, 153);
            this.xoaBt.Name = "xoaBt";
            this.xoaBt.Size = new System.Drawing.Size(120, 27);
            this.xoaBt.TabIndex = 3;
            this.xoaBt.Text = "Xóa";
            this.xoaBt.UseVisualStyleBackColor = true;
            this.xoaBt.Click += new System.EventHandler(this.xoaBt_Click);
            // 
            // suaBt
            // 
            this.suaBt.AutoSize = true;
            this.suaBt.Location = new System.Drawing.Point(294, 187);
            this.suaBt.Name = "suaBt";
            this.suaBt.Size = new System.Drawing.Size(120, 27);
            this.suaBt.TabIndex = 3;
            this.suaBt.Text = "Sửa";
            this.suaBt.UseVisualStyleBackColor = true;
            this.suaBt.Click += new System.EventHandler(this.suaBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 468);
            this.Controls.Add(this.suaBt);
            this.Controls.Add(this.xoaBt);
            this.Controls.Add(this.themSanPhamBt);
            this.Controls.Add(this.donGiaTB);
            this.Controls.Add(this.sanPhamTB);
            this.Controls.Add(this.maTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sanPhamLV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView sanPhamLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maTB;
        private System.Windows.Forms.TextBox sanPhamTB;
        private System.Windows.Forms.TextBox donGiaTB;
        private System.Windows.Forms.Button themSanPhamBt;
        private System.Windows.Forms.Button xoaBt;
        private System.Windows.Forms.Button suaBt;
    }
}

