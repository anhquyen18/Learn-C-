
namespace Bai54
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
            this.maTB = new System.Windows.Forms.TextBox();
            this.tenTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namSinhDTP = new System.Windows.Forms.DateTimePicker();
            this.themSVBt = new System.Windows.Forms.Button();
            this.luuSVBt = new System.Windows.Forms.Button();
            this.docSVBt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.svLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // maTB
            // 
            this.maTB.Location = new System.Drawing.Point(203, 72);
            this.maTB.Name = "maTB";
            this.maTB.Size = new System.Drawing.Size(200, 26);
            this.maTB.TabIndex = 1;
            // 
            // tenTB
            // 
            this.tenTB.Location = new System.Drawing.Point(203, 130);
            this.tenTB.Name = "tenTB";
            this.tenTB.Size = new System.Drawing.Size(200, 26);
            this.tenTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm sinh:";
            // 
            // namSinhDTP
            // 
            this.namSinhDTP.Location = new System.Drawing.Point(203, 197);
            this.namSinhDTP.Name = "namSinhDTP";
            this.namSinhDTP.Size = new System.Drawing.Size(200, 26);
            this.namSinhDTP.TabIndex = 2;
            // 
            // themSVBt
            // 
            this.themSVBt.AutoSize = true;
            this.themSVBt.Location = new System.Drawing.Point(97, 287);
            this.themSVBt.Name = "themSVBt";
            this.themSVBt.Size = new System.Drawing.Size(132, 30);
            this.themSVBt.TabIndex = 3;
            this.themSVBt.Text = "Thêm sinh viên";
            this.themSVBt.UseVisualStyleBackColor = true;
            this.themSVBt.Click += new System.EventHandler(this.themSVBt_Click);
            // 
            // luuSVBt
            // 
            this.luuSVBt.AutoSize = true;
            this.luuSVBt.Location = new System.Drawing.Point(245, 287);
            this.luuSVBt.Name = "luuSVBt";
            this.luuSVBt.Size = new System.Drawing.Size(118, 30);
            this.luuSVBt.TabIndex = 3;
            this.luuSVBt.Text = "Lưu sinh viên";
            this.luuSVBt.UseVisualStyleBackColor = true;
            this.luuSVBt.Click += new System.EventHandler(this.luuSVBt_Click);
            // 
            // docSVBt
            // 
            this.docSVBt.AutoSize = true;
            this.docSVBt.Location = new System.Drawing.Point(409, 287);
            this.docSVBt.Name = "docSVBt";
            this.docSVBt.Size = new System.Drawing.Size(120, 30);
            this.docSVBt.TabIndex = 3;
            this.docSVBt.Text = "Đọc sinh viên";
            this.docSVBt.UseVisualStyleBackColor = true;
            this.docSVBt.Click += new System.EventHandler(this.docSVBt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách sinh viên:";
            // 
            // svLB
            // 
            this.svLB.FormattingEnabled = true;
            this.svLB.ItemHeight = 20;
            this.svLB.Location = new System.Drawing.Point(83, 370);
            this.svLB.Name = "svLB";
            this.svLB.Size = new System.Drawing.Size(433, 164);
            this.svLB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 576);
            this.Controls.Add(this.svLB);
            this.Controls.Add(this.docSVBt);
            this.Controls.Add(this.luuSVBt);
            this.Controls.Add(this.themSVBt);
            this.Controls.Add(this.namSinhDTP);
            this.Controls.Add(this.tenTB);
            this.Controls.Add(this.maTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maTB;
        private System.Windows.Forms.TextBox tenTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker namSinhDTP;
        private System.Windows.Forms.Button themSVBt;
        private System.Windows.Forms.Button luuSVBt;
        private System.Windows.Forms.Button docSVBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox svLB;
    }
}

