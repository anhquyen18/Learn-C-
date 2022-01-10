
namespace Bai55
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maTB = new System.Windows.Forms.TextBox();
            this.tenTB = new System.Windows.Forms.TextBox();
            this.namSinhDTP = new System.Windows.Forms.DateTimePicker();
            this.themBt = new System.Windows.Forms.Button();
            this.luuBt = new System.Windows.Forms.Button();
            this.docBt = new System.Windows.Forms.Button();
            this.danhSachLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm sinh:";
            // 
            // maTB
            // 
            this.maTB.Location = new System.Drawing.Point(229, 33);
            this.maTB.Name = "maTB";
            this.maTB.Size = new System.Drawing.Size(313, 26);
            this.maTB.TabIndex = 1;
            // 
            // tenTB
            // 
            this.tenTB.Location = new System.Drawing.Point(229, 93);
            this.tenTB.Name = "tenTB";
            this.tenTB.Size = new System.Drawing.Size(313, 26);
            this.tenTB.TabIndex = 1;
            // 
            // namSinhDTP
            // 
            this.namSinhDTP.Location = new System.Drawing.Point(229, 154);
            this.namSinhDTP.Name = "namSinhDTP";
            this.namSinhDTP.Size = new System.Drawing.Size(313, 26);
            this.namSinhDTP.TabIndex = 2;
            // 
            // themBt
            // 
            this.themBt.AutoSize = true;
            this.themBt.Location = new System.Drawing.Point(229, 208);
            this.themBt.Name = "themBt";
            this.themBt.Size = new System.Drawing.Size(88, 30);
            this.themBt.TabIndex = 3;
            this.themBt.Text = "Thêm SV";
            this.themBt.UseVisualStyleBackColor = true;
            this.themBt.Click += new System.EventHandler(this.themBt_Click);
            // 
            // luuBt
            // 
            this.luuBt.AutoSize = true;
            this.luuBt.Location = new System.Drawing.Point(334, 208);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(75, 30);
            this.luuBt.TabIndex = 3;
            this.luuBt.Text = "Lưu SV";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // docBt
            // 
            this.docBt.AutoSize = true;
            this.docBt.Location = new System.Drawing.Point(435, 208);
            this.docBt.Name = "docBt";
            this.docBt.Size = new System.Drawing.Size(76, 30);
            this.docBt.TabIndex = 3;
            this.docBt.Text = "Đọc SV";
            this.docBt.UseVisualStyleBackColor = true;
            this.docBt.Click += new System.EventHandler(this.docBt_Click);
            // 
            // danhSachLB
            // 
            this.danhSachLB.FormattingEnabled = true;
            this.danhSachLB.ItemHeight = 20;
            this.danhSachLB.Location = new System.Drawing.Point(229, 271);
            this.danhSachLB.Name = "danhSachLB";
            this.danhSachLB.Size = new System.Drawing.Size(313, 184);
            this.danhSachLB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách sinh viên:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 495);
            this.Controls.Add(this.danhSachLB);
            this.Controls.Add(this.docBt);
            this.Controls.Add(this.luuBt);
            this.Controls.Add(this.themBt);
            this.Controls.Add(this.namSinhDTP);
            this.Controls.Add(this.tenTB);
            this.Controls.Add(this.maTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maTB;
        private System.Windows.Forms.TextBox tenTB;
        private System.Windows.Forms.DateTimePicker namSinhDTP;
        private System.Windows.Forms.Button themBt;
        private System.Windows.Forms.Button luuBt;
        private System.Windows.Forms.Button docBt;
        private System.Windows.Forms.ListBox danhSachLB;
        private System.Windows.Forms.Label label4;
    }
}

