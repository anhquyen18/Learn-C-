
namespace Bai30
{
    partial class SinhVienForm
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
            this.sinhVienLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maTB = new System.Windows.Forms.TextBox();
            this.tenTB = new System.Windows.Forms.TextBox();
            this.luuBt = new System.Windows.Forms.Button();
            this.xoaBt = new System.Windows.Forms.Button();
            this.leBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinhVienLB
            // 
            this.sinhVienLB.FormattingEnabled = true;
            this.sinhVienLB.ItemHeight = 16;
            this.sinhVienLB.Location = new System.Drawing.Point(4, 125);
            this.sinhVienLB.Name = "sinhVienLB";
            this.sinhVienLB.Size = new System.Drawing.Size(370, 164);
            this.sinhVienLB.TabIndex = 6;
            this.sinhVienLB.SelectedIndexChanged += new System.EventHandler(this.sinhVienLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // maTB
            // 
            this.maTB.Location = new System.Drawing.Point(88, 6);
            this.maTB.Name = "maTB";
            this.maTB.Size = new System.Drawing.Size(243, 22);
            this.maTB.TabIndex = 2;
            // 
            // tenTB
            // 
            this.tenTB.Location = new System.Drawing.Point(88, 40);
            this.tenTB.Name = "tenTB";
            this.tenTB.Size = new System.Drawing.Size(243, 22);
            this.tenTB.TabIndex = 3;
            // 
            // luuBt
            // 
            this.luuBt.Location = new System.Drawing.Point(88, 75);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(90, 33);
            this.luuBt.TabIndex = 4;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // xoaBt
            // 
            this.xoaBt.Location = new System.Drawing.Point(214, 75);
            this.xoaBt.Name = "xoaBt";
            this.xoaBt.Size = new System.Drawing.Size(90, 33);
            this.xoaBt.TabIndex = 5;
            this.xoaBt.Text = "Xóa";
            this.xoaBt.UseVisualStyleBackColor = true;
            this.xoaBt.Click += new System.EventHandler(this.xoaBt_Click);
            // 
            // leBt
            // 
            this.leBt.Location = new System.Drawing.Point(40, 315);
            this.leBt.Name = "leBt";
            this.leBt.Size = new System.Drawing.Size(224, 23);
            this.leBt.TabIndex = 7;
            this.leBt.Text = "Sinh Viên có MSSV lẻ";
            this.leBt.UseVisualStyleBackColor = true;
            this.leBt.Click += new System.EventHandler(this.leBt_Click);
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 350);
            this.Controls.Add(this.leBt);
            this.Controls.Add(this.xoaBt);
            this.Controls.Add(this.luuBt);
            this.Controls.Add(this.tenTB);
            this.Controls.Add(this.maTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sinhVienLB);
            this.Name = "SinhVienForm";
            this.Text = "SinhVienForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sinhVienLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maTB;
        private System.Windows.Forms.TextBox tenTB;
        private System.Windows.Forms.Button luuBt;
        private System.Windows.Forms.Button xoaBt;
        private System.Windows.Forms.Button leBt;
    }
}