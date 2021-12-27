
namespace Bai26
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
            this.hoTenLb = new System.Windows.Forms.Label();
            this.hoLb = new System.Windows.Forms.Label();
            this.tenLb = new System.Windows.Forms.Label();
            this.hoTb = new System.Windows.Forms.TextBox();
            this.tenTb = new System.Windows.Forms.TextBox();
            this.hoBt = new System.Windows.Forms.Button();
            this.thoatBt = new System.Windows.Forms.Button();
            this.tenBt = new System.Windows.Forms.Button();
            this.hoTenBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoTenLb
            // 
            this.hoTenLb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.hoTenLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.hoTenLb.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenLb.Location = new System.Drawing.Point(0, 0);
            this.hoTenLb.Name = "hoTenLb";
            this.hoTenLb.Size = new System.Drawing.Size(456, 60);
            this.hoTenLb.TabIndex = 0;
            this.hoTenLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoLb
            // 
            this.hoLb.AutoSize = true;
            this.hoLb.Location = new System.Drawing.Point(47, 88);
            this.hoLb.Name = "hoLb";
            this.hoLb.Size = new System.Drawing.Size(26, 17);
            this.hoLb.TabIndex = 1;
            this.hoLb.Text = "Họ";
            // 
            // tenLb
            // 
            this.tenLb.AutoSize = true;
            this.tenLb.Location = new System.Drawing.Point(47, 147);
            this.tenLb.Name = "tenLb";
            this.tenLb.Size = new System.Drawing.Size(33, 17);
            this.tenLb.TabIndex = 2;
            this.tenLb.Text = "Tên";
            // 
            // hoTb
            // 
            this.hoTb.Location = new System.Drawing.Point(163, 85);
            this.hoTb.Name = "hoTb";
            this.hoTb.Size = new System.Drawing.Size(247, 22);
            this.hoTb.TabIndex = 3;
            // 
            // tenTb
            // 
            this.tenTb.Location = new System.Drawing.Point(163, 147);
            this.tenTb.Name = "tenTb";
            this.tenTb.Size = new System.Drawing.Size(247, 22);
            this.tenTb.TabIndex = 4;
            // 
            // hoBt
            // 
            this.hoBt.Location = new System.Drawing.Point(28, 197);
            this.hoBt.Name = "hoBt";
            this.hoBt.Size = new System.Drawing.Size(91, 38);
            this.hoBt.TabIndex = 5;
            this.hoBt.Text = "&Họ";
            this.hoBt.UseVisualStyleBackColor = true;
            this.hoBt.Click += new System.EventHandler(this.hoBt_Click);
            // 
            // thoatBt
            // 
            this.thoatBt.AutoSize = true;
            this.thoatBt.Location = new System.Drawing.Point(186, 266);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(75, 27);
            this.thoatBt.TabIndex = 8;
            this.thoatBt.Text = "&Thoát";
            this.thoatBt.UseVisualStyleBackColor = true;
            this.thoatBt.Click += new System.EventHandler(this.thoatBt_Click);
            // 
            // tenBt
            // 
            this.tenBt.Location = new System.Drawing.Point(178, 197);
            this.tenBt.Name = "tenBt";
            this.tenBt.Size = new System.Drawing.Size(91, 38);
            this.tenBt.TabIndex = 6;
            this.tenBt.Text = "&Tên";
            this.tenBt.UseVisualStyleBackColor = true;
            this.tenBt.Click += new System.EventHandler(this.tenBt_Click);
            // 
            // hoTenBt
            // 
            this.hoTenBt.AccessibleDescription = "";
            this.hoTenBt.Location = new System.Drawing.Point(319, 197);
            this.hoTenBt.Name = "hoTenBt";
            this.hoTenBt.Size = new System.Drawing.Size(91, 38);
            this.hoTenBt.TabIndex = 7;
            this.hoTenBt.Text = "Họ &và Tên";
            this.hoTenBt.UseVisualStyleBackColor = true;
            this.hoTenBt.Click += new System.EventHandler(this.hoTenBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 316);
            this.Controls.Add(this.thoatBt);
            this.Controls.Add(this.hoTenBt);
            this.Controls.Add(this.tenBt);
            this.Controls.Add(this.hoBt);
            this.Controls.Add(this.tenTb);
            this.Controls.Add(this.hoTb);
            this.Controls.Add(this.tenLb);
            this.Controls.Add(this.hoLb);
            this.Controls.Add(this.hoTenLb);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoTenLb;
        private System.Windows.Forms.Label hoLb;
        private System.Windows.Forms.Label tenLb;
        private System.Windows.Forms.TextBox hoTb;
        private System.Windows.Forms.TextBox tenTb;
        private System.Windows.Forms.Button hoBt;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.Button tenBt;
        private System.Windows.Forms.Button hoTenBt;
    }
}

