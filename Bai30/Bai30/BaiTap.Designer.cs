
namespace Bai30
{
    partial class BaiTap
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
            this.tenSVLb = new System.Windows.Forms.Label();
            this.lopALB = new System.Windows.Forms.ListBox();
            this.lopBLB = new System.Windows.Forms.ListBox();
            this.nhapTenTB = new System.Windows.Forms.TextBox();
            this.chuyenABt = new System.Windows.Forms.Button();
            this.chuyenToanBoABt = new System.Windows.Forms.Button();
            this.chuyenBBt = new System.Windows.Forms.Button();
            this.chuyenToanBoBBt = new System.Windows.Forms.Button();
            this.xoaABt = new System.Windows.Forms.Button();
            this.ketThucBt = new System.Windows.Forms.Button();
            this.xoaBBt = new System.Windows.Forms.Button();
            this.capNhatBt = new System.Windows.Forms.Button();
            this.tenRongEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.chonLopCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tenRongEr)).BeginInit();
            this.SuspendLayout();
            // 
            // tenSVLb
            // 
            this.tenSVLb.AutoSize = true;
            this.tenSVLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSVLb.Location = new System.Drawing.Point(12, 9);
            this.tenSVLb.Name = "tenSVLb";
            this.tenSVLb.Size = new System.Drawing.Size(93, 25);
            this.tenSVLb.TabIndex = 0;
            this.tenSVLb.Text = "Tên SV:";
            // 
            // lopALB
            // 
            this.lopALB.FormattingEnabled = true;
            this.lopALB.ItemHeight = 16;
            this.lopALB.Location = new System.Drawing.Point(29, 52);
            this.lopALB.Name = "lopALB";
            this.lopALB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lopALB.Size = new System.Drawing.Size(143, 180);
            this.lopALB.TabIndex = 10;
            // 
            // lopBLB
            // 
            this.lopBLB.FormattingEnabled = true;
            this.lopBLB.ItemHeight = 16;
            this.lopBLB.Location = new System.Drawing.Point(312, 52);
            this.lopBLB.Name = "lopBLB";
            this.lopBLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lopBLB.Size = new System.Drawing.Size(136, 180);
            this.lopBLB.TabIndex = 11;
            // 
            // nhapTenTB
            // 
            this.nhapTenTB.Location = new System.Drawing.Point(111, 12);
            this.nhapTenTB.Name = "nhapTenTB";
            this.nhapTenTB.Size = new System.Drawing.Size(230, 22);
            this.nhapTenTB.TabIndex = 1;
            // 
            // chuyenABt
            // 
            this.chuyenABt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyenABt.Location = new System.Drawing.Point(200, 73);
            this.chuyenABt.Name = "chuyenABt";
            this.chuyenABt.Size = new System.Drawing.Size(76, 33);
            this.chuyenABt.TabIndex = 3;
            this.chuyenABt.Text = ">";
            this.chuyenABt.UseVisualStyleBackColor = true;
            this.chuyenABt.Click += new System.EventHandler(this.chuyenABt_Click);
            // 
            // chuyenToanBoABt
            // 
            this.chuyenToanBoABt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyenToanBoABt.Location = new System.Drawing.Point(200, 112);
            this.chuyenToanBoABt.Name = "chuyenToanBoABt";
            this.chuyenToanBoABt.Size = new System.Drawing.Size(76, 33);
            this.chuyenToanBoABt.TabIndex = 4;
            this.chuyenToanBoABt.Text = ">>";
            this.chuyenToanBoABt.UseVisualStyleBackColor = true;
            this.chuyenToanBoABt.Click += new System.EventHandler(this.chuyenToanBoABt_Click);
            // 
            // chuyenBBt
            // 
            this.chuyenBBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyenBBt.Location = new System.Drawing.Point(200, 167);
            this.chuyenBBt.Name = "chuyenBBt";
            this.chuyenBBt.Size = new System.Drawing.Size(76, 33);
            this.chuyenBBt.TabIndex = 5;
            this.chuyenBBt.Text = "<";
            this.chuyenBBt.UseVisualStyleBackColor = true;
            this.chuyenBBt.Click += new System.EventHandler(this.chuyenBBt_Click);
            // 
            // chuyenToanBoBBt
            // 
            this.chuyenToanBoBBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyenToanBoBBt.Location = new System.Drawing.Point(200, 206);
            this.chuyenToanBoBBt.Name = "chuyenToanBoBBt";
            this.chuyenToanBoBBt.Size = new System.Drawing.Size(76, 33);
            this.chuyenToanBoBBt.TabIndex = 6;
            this.chuyenToanBoBBt.Text = "<<";
            this.chuyenToanBoBBt.UseVisualStyleBackColor = true;
            this.chuyenToanBoBBt.Click += new System.EventHandler(this.chuyenToanBoBBt_Click);
            // 
            // xoaABt
            // 
            this.xoaABt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaABt.Location = new System.Drawing.Point(38, 252);
            this.xoaABt.Name = "xoaABt";
            this.xoaABt.Size = new System.Drawing.Size(124, 33);
            this.xoaABt.TabIndex = 7;
            this.xoaABt.Text = "Xóa lớp A";
            this.xoaABt.UseVisualStyleBackColor = true;
            this.xoaABt.Click += new System.EventHandler(this.xoaABt_Click);
            // 
            // ketThucBt
            // 
            this.ketThucBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketThucBt.Location = new System.Drawing.Point(191, 252);
            this.ketThucBt.Name = "ketThucBt";
            this.ketThucBt.Size = new System.Drawing.Size(101, 33);
            this.ketThucBt.TabIndex = 8;
            this.ketThucBt.Text = "Kết thúc";
            this.ketThucBt.UseVisualStyleBackColor = true;
            this.ketThucBt.Click += new System.EventHandler(this.ketThucBt_Click);
            // 
            // xoaBBt
            // 
            this.xoaBBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBBt.Location = new System.Drawing.Point(321, 252);
            this.xoaBBt.Name = "xoaBBt";
            this.xoaBBt.Size = new System.Drawing.Size(123, 33);
            this.xoaBBt.TabIndex = 9;
            this.xoaBBt.Text = "Xóa lớp B";
            this.xoaBBt.UseVisualStyleBackColor = true;
            this.xoaBBt.Click += new System.EventHandler(this.xoaBBt_Click);
            // 
            // capNhatBt
            // 
            this.capNhatBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhatBt.Location = new System.Drawing.Point(373, 7);
            this.capNhatBt.Name = "capNhatBt";
            this.capNhatBt.Size = new System.Drawing.Size(113, 33);
            this.capNhatBt.TabIndex = 2;
            this.capNhatBt.Text = "Cập nhật";
            this.capNhatBt.UseVisualStyleBackColor = true;
            this.capNhatBt.Click += new System.EventHandler(this.capNhatBt_Click);
            // 
            // tenRongEr
            // 
            this.tenRongEr.ContainerControl = this;
            // 
            // chonLopCB
            // 
            this.chonLopCB.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B"});
            this.chonLopCB.Location = new System.Drawing.Point(178, 40);
            this.chonLopCB.Name = "chonLopCB";
            this.chonLopCB.Size = new System.Drawing.Size(121, 24);
            this.chonLopCB.TabIndex = 12;
            // 
            // BaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 299);
            this.Controls.Add(this.chonLopCB);
            this.Controls.Add(this.xoaBBt);
            this.Controls.Add(this.ketThucBt);
            this.Controls.Add(this.xoaABt);
            this.Controls.Add(this.chuyenToanBoBBt);
            this.Controls.Add(this.chuyenBBt);
            this.Controls.Add(this.chuyenToanBoABt);
            this.Controls.Add(this.capNhatBt);
            this.Controls.Add(this.chuyenABt);
            this.Controls.Add(this.nhapTenTB);
            this.Controls.Add(this.lopBLB);
            this.Controls.Add(this.lopALB);
            this.Controls.Add(this.tenSVLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaiTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập ListBox";
            ((System.ComponentModel.ISupportInitialize)(this.tenRongEr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenSVLb;
        private System.Windows.Forms.ListBox lopALB;
        private System.Windows.Forms.ListBox lopBLB;
        private System.Windows.Forms.TextBox nhapTenTB;
        private System.Windows.Forms.Button chuyenABt;
        private System.Windows.Forms.Button chuyenToanBoABt;
        private System.Windows.Forms.Button chuyenBBt;
        private System.Windows.Forms.Button chuyenToanBoBBt;
        private System.Windows.Forms.Button xoaABt;
        private System.Windows.Forms.Button ketThucBt;
        private System.Windows.Forms.Button xoaBBt;
        private System.Windows.Forms.Button capNhatBt;
        private System.Windows.Forms.ErrorProvider tenRongEr;
        private System.Windows.Forms.ComboBox chonLopCB;
    }
}