
namespace Bai28
{
    partial class LoginForm
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
            this.luuCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dangNhapBt = new System.Windows.Forms.Button();
            this.thoatBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // luuCB
            // 
            this.luuCB.AutoSize = true;
            this.luuCB.CausesValidation = false;
            this.luuCB.ForeColor = System.Drawing.Color.Yellow;
            this.luuCB.Location = new System.Drawing.Point(94, 109);
            this.luuCB.Name = "luuCB";
            this.luuCB.Size = new System.Drawing.Size(185, 21);
            this.luuCB.TabIndex = 1;
            this.luuCB.Text = "Lưu thông tin đăng nhập";
            this.luuCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(94, 29);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(273, 22);
            this.userNameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(94, 68);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(273, 22);
            this.passwordTB.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai28.Properties.Resources._122225007_2103548803111416_4211120638506685716_n;
            this.pictureBox1.Location = new System.Drawing.Point(404, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng nhập hệ thống quản lý";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thoatBt);
            this.groupBox1.Controls.Add(this.dangNhapBt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.luuCB);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.userNameTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 202);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dangNhapBt
            // 
            this.dangNhapBt.AutoSize = true;
            this.dangNhapBt.Location = new System.Drawing.Point(18, 161);
            this.dangNhapBt.Name = "dangNhapBt";
            this.dangNhapBt.Size = new System.Drawing.Size(136, 27);
            this.dangNhapBt.TabIndex = 3;
            this.dangNhapBt.Text = "Đăng nhập";
            this.dangNhapBt.UseVisualStyleBackColor = true;
            this.dangNhapBt.Click += new System.EventHandler(this.dangNhapBt_Click);
            // 
            // thoatBt
            // 
            this.thoatBt.AutoSize = true;
            this.thoatBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.thoatBt.Location = new System.Drawing.Point(195, 161);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(159, 27);
            this.thoatBt.TabIndex = 3;
            this.thoatBt.Text = "Thoát";
            this.thoatBt.UseVisualStyleBackColor = true;
            this.thoatBt.Click += new System.EventHandler(this.thoatBt_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "LoginForm";
            this.Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox luuCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.Button dangNhapBt;
    }
}