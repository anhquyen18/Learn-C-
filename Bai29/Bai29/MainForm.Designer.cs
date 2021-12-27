
namespace Bai29
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
            this.components = new System.ComponentModel.Container();
            this.tenLb = new System.Windows.Forms.Label();
            this.tuoiLb = new System.Windows.Forms.Label();
            this.ngayDangKyLb = new System.Windows.Forms.Label();
            this.tenTB = new System.Windows.Forms.TextBox();
            this.tuoiTB = new System.Windows.Forms.TextBox();
            this.dangKyBt = new System.Windows.Forms.Button();
            this.ngayDangKyDTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenLb
            // 
            this.tenLb.AutoSize = true;
            this.tenLb.Location = new System.Drawing.Point(31, 33);
            this.tenLb.Name = "tenLb";
            this.tenLb.Size = new System.Drawing.Size(37, 17);
            this.tenLb.TabIndex = 0;
            this.tenLb.Text = "Tên:";
            // 
            // tuoiLb
            // 
            this.tuoiLb.AutoSize = true;
            this.tuoiLb.Location = new System.Drawing.Point(31, 71);
            this.tuoiLb.Name = "tuoiLb";
            this.tuoiLb.Size = new System.Drawing.Size(40, 17);
            this.tuoiLb.TabIndex = 0;
            this.tuoiLb.Text = "Tuổi:";
            // 
            // ngayDangKyLb
            // 
            this.ngayDangKyLb.AutoSize = true;
            this.ngayDangKyLb.Location = new System.Drawing.Point(6, 105);
            this.ngayDangKyLb.Name = "ngayDangKyLb";
            this.ngayDangKyLb.Size = new System.Drawing.Size(99, 17);
            this.ngayDangKyLb.TabIndex = 0;
            this.ngayDangKyLb.Text = "Ngày đăng ký:";
            // 
            // tenTB
            // 
            this.tenTB.Location = new System.Drawing.Point(110, 30);
            this.tenTB.Name = "tenTB";
            this.tenTB.Size = new System.Drawing.Size(231, 22);
            this.tenTB.TabIndex = 1;
            // 
            // tuoiTB
            // 
            this.tuoiTB.Location = new System.Drawing.Point(110, 66);
            this.tuoiTB.Name = "tuoiTB";
            this.tuoiTB.Size = new System.Drawing.Size(231, 22);
            this.tuoiTB.TabIndex = 2;
            // 
            // dangKyBt
            // 
            this.dangKyBt.AutoSize = true;
            this.dangKyBt.Location = new System.Drawing.Point(150, 128);
            this.dangKyBt.Name = "dangKyBt";
            this.dangKyBt.Size = new System.Drawing.Size(105, 37);
            this.dangKyBt.TabIndex = 4;
            this.dangKyBt.Text = "Đăng ký";
            this.dangKyBt.UseVisualStyleBackColor = true;
            this.dangKyBt.Click += new System.EventHandler(this.dangKyBt_Click);
            // 
            // ngayDangKyDTP
            // 
            this.ngayDangKyDTP.CustomFormat = "dd/MM/yyyyy";
            this.ngayDangKyDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayDangKyDTP.Location = new System.Drawing.Point(111, 100);
            this.ngayDangKyDTP.Name = "ngayDangKyDTP";
            this.ngayDangKyDTP.Size = new System.Drawing.Size(230, 22);
            this.ngayDangKyDTP.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngayDangKyDTP);
            this.groupBox1.Controls.Add(this.dangKyBt);
            this.groupBox1.Controls.Add(this.tuoiTB);
            this.groupBox1.Controls.Add(this.tenTB);
            this.groupBox1.Controls.Add(this.ngayDangKyLb);
            this.groupBox1.Controls.Add(this.tuoiLb);
            this.groupBox1.Controls.Add(this.tenLb);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng ký thi bằng lái xe";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 200);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form đăng ký";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tenLb;
        private System.Windows.Forms.Label tuoiLb;
        private System.Windows.Forms.Label ngayDangKyLb;
        private System.Windows.Forms.TextBox tenTB;
        private System.Windows.Forms.TextBox tuoiTB;
        private System.Windows.Forms.Button dangKyBt;
        private System.Windows.Forms.DateTimePicker ngayDangKyDTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

