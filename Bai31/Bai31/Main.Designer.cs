
namespace Bai31
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.headingLb = new System.Windows.Forms.Label();
            this.tenLb = new System.Windows.Forms.Label();
            this.soDTLb = new System.Windows.Forms.Label();
            this.PTTTCB = new System.Windows.Forms.ComboBox();
            this.PTTTLb = new System.Windows.Forms.Label();
            this.tenTB = new System.Windows.Forms.TextBox();
            this.soDTTB = new System.Windows.Forms.TextBox();
            this.datHangBt = new System.Windows.Forms.Button();
            this.thoatBt = new System.Windows.Forms.Button();
            this.danhSachLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chiTietTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // headingLb
            // 
            this.headingLb.AutoSize = true;
            this.headingLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLb.ForeColor = System.Drawing.Color.Turquoise;
            this.headingLb.Location = new System.Drawing.Point(191, 9);
            this.headingLb.Name = "headingLb";
            this.headingLb.Size = new System.Drawing.Size(239, 29);
            this.headingLb.TabIndex = 0;
            this.headingLb.Text = "Màn hình đặt hàng";
            // 
            // tenLb
            // 
            this.tenLb.AutoSize = true;
            this.tenLb.Location = new System.Drawing.Point(22, 48);
            this.tenLb.Name = "tenLb";
            this.tenLb.Size = new System.Drawing.Size(37, 17);
            this.tenLb.TabIndex = 1;
            this.tenLb.Text = "Tên:";
            // 
            // soDTLb
            // 
            this.soDTLb.AutoSize = true;
            this.soDTLb.Location = new System.Drawing.Point(22, 79);
            this.soDTLb.Name = "soDTLb";
            this.soDTLb.Size = new System.Drawing.Size(40, 17);
            this.soDTLb.TabIndex = 2;
            this.soDTLb.Text = "SĐT:";
            // 
            // PTTTCB
            // 
            this.PTTTCB.FormattingEnabled = true;
            this.PTTTCB.Items.AddRange(new object[] {
            "ATM",
            "Gửi tiền tại cửa hàng",
            "Gửi tiền sau khi nhận hàng"});
            this.PTTTCB.Location = new System.Drawing.Point(25, 301);
            this.PTTTCB.Name = "PTTTCB";
            this.PTTTCB.Size = new System.Drawing.Size(291, 24);
            this.PTTTCB.TabIndex = 7;
            this.PTTTCB.SelectedIndexChanged += new System.EventHandler(this.PTTTCB_SelectedIndexChanged);
            // 
            // PTTTLb
            // 
            this.PTTTLb.AutoSize = true;
            this.PTTTLb.Location = new System.Drawing.Point(22, 280);
            this.PTTTLb.Name = "PTTTLb";
            this.PTTTLb.Size = new System.Drawing.Size(200, 17);
            this.PTTTLb.TabIndex = 6;
            this.PTTTLb.Text = "Chọn phương thức thanh toán:";
            // 
            // tenTB
            // 
            this.tenTB.Location = new System.Drawing.Point(81, 48);
            this.tenTB.Name = "tenTB";
            this.tenTB.Size = new System.Drawing.Size(196, 22);
            this.tenTB.TabIndex = 3;
            // 
            // soDTTB
            // 
            this.soDTTB.Location = new System.Drawing.Point(81, 76);
            this.soDTTB.Name = "soDTTB";
            this.soDTTB.Size = new System.Drawing.Size(196, 22);
            this.soDTTB.TabIndex = 4;
            // 
            // datHangBt
            // 
            this.datHangBt.AutoSize = true;
            this.datHangBt.Location = new System.Drawing.Point(118, 364);
            this.datHangBt.Name = "datHangBt";
            this.datHangBt.Size = new System.Drawing.Size(76, 27);
            this.datHangBt.TabIndex = 8;
            this.datHangBt.Text = "Đặt hàng";
            this.datHangBt.UseVisualStyleBackColor = true;
            this.datHangBt.Click += new System.EventHandler(this.datHangBt_Click);
            // 
            // thoatBt
            // 
            this.thoatBt.AutoSize = true;
            this.thoatBt.Location = new System.Drawing.Point(426, 364);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(75, 27);
            this.thoatBt.TabIndex = 11;
            this.thoatBt.Text = "Thoát";
            this.thoatBt.UseVisualStyleBackColor = true;
            // 
            // danhSachLB
            // 
            this.danhSachLB.FormattingEnabled = true;
            this.danhSachLB.ItemHeight = 16;
            this.danhSachLB.Items.AddRange(new object[] {
            "Iphone 13",
            "Mì tôm hảo hảo",
            "Samsung galaxy note 20 Ultra",
            "Sữa chua Vinamilk"});
            this.danhSachLB.Location = new System.Drawing.Point(25, 109);
            this.danhSachLB.Name = "danhSachLB";
            this.danhSachLB.Size = new System.Drawing.Size(291, 164);
            this.danhSachLB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin chi tiết đơn hàng:";
            // 
            // chiTietTB
            // 
            this.chiTietTB.Location = new System.Drawing.Point(323, 81);
            this.chiTietTB.Multiline = true;
            this.chiTietTB.Name = "chiTietTB";
            this.chiTietTB.Size = new System.Drawing.Size(291, 244);
            this.chiTietTB.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ATM",
            "Gửi tiền tại cửa hàng",
            "Gửi tiền sau khi nhận hàng"});
            this.comboBox1.Location = new System.Drawing.Point(25, 334);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.PTTTCB_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 415);
            this.Controls.Add(this.danhSachLB);
            this.Controls.Add(this.thoatBt);
            this.Controls.Add(this.datHangBt);
            this.Controls.Add(this.chiTietTB);
            this.Controls.Add(this.soDTTB);
            this.Controls.Add(this.tenTB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PTTTCB);
            this.Controls.Add(this.PTTTLb);
            this.Controls.Add(this.soDTLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenLb);
            this.Controls.Add(this.headingLb);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLb;
        private System.Windows.Forms.Label tenLb;
        private System.Windows.Forms.Label soDTLb;
        private System.Windows.Forms.ComboBox PTTTCB;
        private System.Windows.Forms.Label PTTTLb;
        private System.Windows.Forms.TextBox tenTB;
        private System.Windows.Forms.TextBox soDTTB;
        private System.Windows.Forms.Button datHangBt;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.ListBox danhSachLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chiTietTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

